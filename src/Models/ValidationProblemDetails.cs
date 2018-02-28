namespace MyBp.Models
{
    using System;
    using System.Collections.Generic;

    public class ValidationProblemDetails : ProblemDetails
    {
        public IDictionary<string, string[]> Errors { get; } = new Dictionary<string, string[]>(StringComparer.Ordinal);
    }
}
