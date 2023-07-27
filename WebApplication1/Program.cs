using coreAuthenticationMiddlewares.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/*app.MapGet("/", () => "Hello World!");*/

app.UseFirstCustomMiddleware();

/*// Middleware A
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware A (Before) => ");
    await next();
    await context.Response.WriteAsync("Middleware A (After)");
});

// Middleware B
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware B (Before) => ");
    await next();
    await context.Response.WriteAsync("Middleware B (After)");
});

// Middleware C
app.Run(async (context) =>
{
    await context.Response.WriteAsync("Middleware C => ");
});*/

app.Run();