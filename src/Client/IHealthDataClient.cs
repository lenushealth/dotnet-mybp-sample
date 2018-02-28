using MyBp.Models;
using Refit;
using System.Threading.Tasks;

namespace MyBp.Client
{
    using System.Collections.Generic;

    [Headers("api-version: 2.0", "Authorization: Bearer")]
    public interface IHealthDataClient
    {
        [Post("/api/query")]
        Task<HealthDataQueryResponse> CreateQueryAsync([Body(BodySerializationMethod.Json)] HealthDataQueryRequest request);

        [Get("/api/query")]
        Task<IEnumerable<HealthSample>> ExecuteQueryAsync([Query] string querykey, [Query] int take = 100, [Query] int? skip = null);

        [Post("/api/sample")]
        Task SubmitBloodPressureMeasurementAsync([Body(BodySerializationMethod.Json)] params HealthSample[] samples);
    }
}