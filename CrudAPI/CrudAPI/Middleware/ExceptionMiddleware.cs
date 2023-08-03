using Newtonsoft.Json;
using System.Net;

namespace CrudAPI.Middleware
{
    public class ExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }
            private async Task HandleExceptionAsync(HttpContext context, Exception exception)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

               
                var errorResponse = new ErrorResponse
                {
                    Message = "An error occurred while processing your request.",
                     
                };

              
                var jsonErrorResponse = JsonConvert.SerializeObject(errorResponse);
                await context.Response.WriteAsync(jsonErrorResponse);
            }

    }
            public class ErrorResponse
            {
                public string Message { get; set; }
            }

}
