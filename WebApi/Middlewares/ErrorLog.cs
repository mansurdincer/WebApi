using Microsoft.AspNetCore.Builder;
using System.Net;

namespace WebApi.Middlewares;

public class ErrorLog 
{
    public ErrorLog(RequestDelegate next, ILogger<ErrorLog> Logger)
    {
        Next = next;
        _logger = Logger;
    }

    public RequestDelegate Next { get; }
    private readonly ILogger _logger;

    public Task InvokeAsync(HttpContext context)
    {
        try
        {
            return Next(context);
        }
        catch (Exception ex)
        {
            return HandleExceptionAsync(context, ex);
        }
    }

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

        return context.Response.WriteAsync("Hata");
    }

}

public static class ErrorLogExtensions
{
    public static IApplicationBuilder UseErrorlogMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ErrorLog>();
    }
}

