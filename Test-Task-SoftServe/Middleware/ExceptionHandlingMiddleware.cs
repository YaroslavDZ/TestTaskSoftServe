using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Threading.Tasks;

namespace Test_Task_SoftServe.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next,
            ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var traceId = Guid.NewGuid();
            LogInfoAboutError(traceId, exception, exception.StackTrace);

            var problemDetails = new ProblemDetails();

            switch (exception)
            {
                case ValidationException validationException:
                    {
                        WriteInfoAboutErrorToProblemDetails(
                            problemDetails,
                            "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.1",
                            "Validation error",
                            StatusCodes.Status400BadRequest,
                            context.Request.Path,
                            $"One or more validation errors has occured, traceID: {traceId}");

                        context.Response.StatusCode = StatusCodes.Status400BadRequest;

                        if (validationException.Errors is not null)
                        {
                            problemDetails.Extensions["errors"] = validationException.Errors;
                        }

                        break;
                    }

                default:
                    {
                        WriteInfoAboutErrorToProblemDetails(
                            problemDetails,
                            "https://datatracker.ietf.org/doc/html/rfc7231#section-6.6.1",
                            "Internal Server Error",
                            StatusCodes.Status500InternalServerError,
                            context.Request.Path,
                            $"Internal server error occured, traceID: {traceId}");

                        context.Response.StatusCode = StatusCodes.Status500InternalServerError;

                        break;
                    }
            }

            await context.Response.WriteAsJsonAsync(problemDetails);
        }

        private void LogInfoAboutError(Guid traceId, Exception ex, string? stackTrace)
        {
            if (ex.InnerException is not null)
            {
                _logger.LogError($"\nTraceID: {traceId}; Type: {ex.InnerException.GetType()};" +
                    $"Message: {ex.InnerException.Message}; StackTrace: {stackTrace}");
            }
            else
            {
                _logger.LogError($"\nTraceID: {traceId}; Type: {ex.GetType()};" +
                    $"Message: {ex.Message}; StackTrace: {stackTrace}");
            }
        }

        private static void WriteInfoAboutErrorToProblemDetails(ProblemDetails problemDetails, string errorType, string errorTitle, int errorStatusCode, string errorInstance, string errorDetail)
        {
            problemDetails.Type = errorType;
            problemDetails.Title = errorTitle;
            problemDetails.Status = errorStatusCode;
            problemDetails.Instance = errorInstance;
            problemDetails.Detail = errorDetail;
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ExceptionHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionHandlingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}
