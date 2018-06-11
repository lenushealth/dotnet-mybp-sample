using MyBp.Models;
using Refit;
using System.Threading.Tasks;

namespace MyBp.Client
{
    using System.Collections.Generic;

    [Headers("Authorization: Bearer")]
    public interface IHealthDataClient
    {
        [Post("/query/v1")]
        Task<HealthDataQueryResponse> CreateQueryAsync([Body(BodySerializationMethod.Json)] HealthDataQueryRequest request);

        [Get("/query/v1")]
        Task<IEnumerable<HealthSample>> ExecuteQueryAsync([Query] string querykey, [Query] int take = 100, [Query] int? skip = null);

        [Post("/sample/v1")]
        Task SubmitBloodPressureMeasurementAsync([Body(BodySerializationMethod.Json)] params HealthSample[] samples);
    }
}