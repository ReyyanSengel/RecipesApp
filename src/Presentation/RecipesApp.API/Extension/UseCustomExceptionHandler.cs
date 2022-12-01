using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using RecipesApp.Application.DTOs.CustomResponseDTOs;
using RecipesApp.Application.Exceptions;
using Serilog;
using System.Net.Mime;
using System.Text.Json;

namespace RecipesApp.API.NewFolder
{
    public static class UseCustomExceptionHandler
    {
        public static void UseCustomException(this WebApplication app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.ContentType = MediaTypeNames.Application.Json;
                    var exceptionFeature = context.Features.Get<IExceptionHandlerFeature>();
                    var statusCode = exceptionFeature.Error switch
                    {
                        ClientSideException => 400,
                        NotFoundException => 404,
                        _ => 500
                    };
                    context.Response.StatusCode = statusCode;

                    if (exceptionFeature != null)
                    {
                        Log.Logger.Error("There is a problem :" + exceptionFeature.Error.Message);

                        await context.Response.WriteAsync(JsonSerializer.Serialize(new
                        {
                            StatusCode = statusCode,
                            Message = exceptionFeature.Error.Message,
                            Title = "Hata alındı"
                        }));
                    }
                });
            });
        }
    }
}


