namespace MyBp.Client
{
    using System;
    using Models;

    public class ProblemDetailsException : ProblemDetailsException<ProblemDetails>
    {
        public ProblemDetailsException(ProblemDetails problemDetails) : base(problemDetails)
        {
        }
    }

    public class ProblemDetailsException<T> : ApplicationException where T : ProblemDetails
    {
        public T ProblemDetails { get; }
        
        public ProblemDetailsException(T problemDetails) : base(problemDetails.Detail)
        {
            this.ProblemDetails = problemDetails;
        }
    }

    public class HealthDataClientValidationException : ProblemDetailsException<ValidationProblemDetails>
    {
        public HealthDataClientValidationException(ValidationProblemDetails problemDetails) : base(problemDetails)
        {
        }
    }

    public class HealthDataClientException : ProblemDetailsException<ProblemDetails>
    {
        public HealthDataClientException(ProblemDetails problemDetails) : base(problemDetails)
        {
        }
    }
}
