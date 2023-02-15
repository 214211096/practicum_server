using Microsoft.AspNetCore.Http;

namespace myProject.WebAPI.MiddleWare
{
    public class ShabatMiddleware
    {
        private readonly RequestDelegate _shabat;
        public ShabatMiddleware(RequestDelegate shabat)
        {
            _shabat=shabat;

        }
        //public async Task InvokeAsync(HttpContext context)
        //{
        //    var guid = Guid.NewGuid().ToString();
        //    context.Items.Add("ReqSeq", guid);
        //    Console.WriteLine($"Request{guid} started the pipeline");
        //    await _next(context);
        //    Console.WriteLine($"Request{guid} ended the pipeline");

        //}
    }
}
