using HelloApp.Services;
using HelloApp.Services.Classes;
using HelloApp.Services.Interfaces;
using HelloApp.Services.Middleware;

var builder = WebApplication.CreateBuilder();

//builder.Services.AddTransient<ITimeService, LongTimeService>();
//builder.Services.AddTransient<ICounter, RandomCounter>();
//builder.Services.AddTransient<CounterService>();
//builder.Services.AddTransient<TimeService>();
//builder.Services.AddTransient<IHelloService, UaHelloService>();
//builder.Services.AddTransient<IHelloService, EnHelloService>();
builder.Services.AddSingleton<ValueStorage>();

var valueStorage = new ValueStorage();
builder.Services.AddSingleton<IGenerator>(_ => valueStorage);
builder.Services.AddSingleton<IReader>(_ => valueStorage);

var app = builder.Build();

app.UseMiddleware<GeneratorMiddleware>();
app.UseMiddleware<ReaderMiddleware>();
//app.UseMiddleware<HelloMiddleware>();
//app.UseMiddleware<TimeMiddleware>();
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Hello, Sergey!");
//});
//app.UseMiddleware<CounterMiddleware>();
//app.Run(async (context) =>
//{
//    var timeService = app.Services.GetService<ITimeService>();
//    await context.Response.WriteAsync($"Time: {timeService?.GetTime()}");
//});
app.Run();