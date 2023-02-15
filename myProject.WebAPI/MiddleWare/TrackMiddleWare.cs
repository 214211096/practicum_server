using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace myProject.WebAPI.MiddleWare
{
    public class TrackMiddleWare
    {
        private readonly RequestDelegate _next;
        public TrackMiddleWare(RequestDelegate next)
        {
            _next = next;

        }
        public async Task InvokeAsync(HttpContext context)
        {
            var guid = Guid.NewGuid().ToString();
            context.Items.Add("ReqSeq", guid);
            Console.WriteLine($"Request{guid} started the pipeline");
            await _next(context);
            Console.WriteLine($"Request{guid} ended the pipeline");

        }


    }
    public static class TrackMiddlewareExtension
        {
         public static IApplicationBuilder UseTrack(this IApplicationBuilder builder)
         {
            builder.UseMiddleware<TrackMiddleWare>();
            return builder;
         }
    }

}
