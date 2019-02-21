using MyBp.Models;
using Refit;
using System.Threading.Tasks;

namespace MyBp.Client
{
    using System.Collections.Generic;

    [Headers("Authorization: Bearer", "api-version: 2.0")]
    public interface IHealthDataClient
    {
        [Get("/api/sample")]
        Task<HealthSamplesDto> ExecuteQueryAsync(
            [Query(CollectionFormat.Multi)] IEnumerable<string> types,
            [Query(Format = "O")] Dictionary<string, object> queryDateParams,
            [Query] string orderProperty = "CreationDate",
            [Query] string orderDirection = "Ascending",
            [Query] int take = 100,
            [Query] int? skip = null);

        [Post("/api/sample")]
        Task SubmitBloodPressureMeasurementAsync([Body(BodySerializationMethod.Serialized)] params HealthSample[] samples);
    }
}