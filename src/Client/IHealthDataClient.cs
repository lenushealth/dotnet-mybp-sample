using MyBp.Models;
using Refit;
using System.Threading.Tasks;

namespace MyBp.Client
{
    using System.Collections.Generic;

    [Headers("Authorization: Bearer")]
    public interface IHealthDataClient
    {
        [Get("/sample")]
        Task<HealthSamplesDto> ExecuteQueryAsync(
            [Query(CollectionFormat.Multi)] IEnumerable<string> types,
            [Query(Format = "O")] Dictionary<string, object> queryDateParams,
            [Query] string orderProperty = null,
            [Query] string orderDirection = null,
            [Query] int take = 100,
            [Query] int? skip = null);

        [Post("/sample")]
        Task SubmitBloodPressureMeasurementAsync([Body(BodySerializationMethod.Serialized)] params HealthSample[] samples);
    }
}