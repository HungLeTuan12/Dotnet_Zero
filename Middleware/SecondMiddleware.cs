public class SecondMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        if (context.Request.Path == "/xxx.html")
        {
            context.Response.Headers.Add("Secondmiddleware", "Not secure");
            var dataFromFirstMiddleware = context.Items["DataFirstMiddleware"];
            if (dataFromFirstMiddleware != null)
            {
                await context.Response.WriteAsync((string)dataFromFirstMiddleware);
            }
            await context.Response.WriteAsync("Ban khong duoc truy cap");
        }
        else
        {
            context.Response.Headers.Add("Secondmiddleware", "Do Not secure");
            var dataFromFirstMiddleware = context.Items["DataFirstMiddleware"];
            if (dataFromFirstMiddleware != null)
            {
                await context.Response.WriteAsync((string)dataFromFirstMiddleware);
            }
            await next(context);
        }

    }
}