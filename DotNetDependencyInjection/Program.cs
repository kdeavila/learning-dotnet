using DotNetDependencyInjection.Interfaces;
using DotNetDependencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSingleton<IWelcomeService, WelcomeService>();
//builder.Services.AddScoped<IWelcomeService, WelcomeService>();

builder.Services.AddTransient<IWelcomeService, WelcomeService>();
var app = builder.Build();

app.MapGet("/", async (IWelcomeService welcomeService1, IWelcomeService welcomeService2) =>
{
    string message1 = welcomeService1.GetWelcomeMessage();
    string message2 = welcomeService2.GetWelcomeMessage();
    return $"{message1}\n{message2}";
});

app.Run();