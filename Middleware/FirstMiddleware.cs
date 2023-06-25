public class FirstMiddleware
{
    private readonly RequestDelegate _next;
    public FirstMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine(context.Request.Path);
        context.Items.Add("DataFirstMiddleware", $"<p>URL: {context.Request.Path}</p>");
        // await context.Response.WriteAsync($"<p>URL: {context.Request.Path}</p>");
        await _next(context);
    }
}