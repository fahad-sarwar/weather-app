using System.Text.Json.Serialization;
using App.Core;
using App.Core.Configuration;
using App.Core.Interfaces;
using App.Services;
using Microsoft.AspNetCore.Mvc;
using JsonOptions = Microsoft.AspNetCore.Http.Json.JsonOptions;
using MvcJsonOptions = Microsoft.AspNetCore.Mvc.JsonOptions;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();
var apiConfig = builder.Configuration.GetSection(nameof(ApiConfig)).Get<ApiConfig>();

builder.Services.AddHttpClient<IPlaceService, OpenStreetMapService>(client =>
{
    client.BaseAddress = new Uri(apiConfig.OpenStreetMapConfig.BaseUrl);
    client.DefaultRequestHeaders.Add("User-Agent", "Aspire");
});

builder.Services.AddHttpClient<IWeatherForecastService, OpenMeteoService>(client =>
{
    client.BaseAddress = new Uri(apiConfig.OpenMeteoConfig.BaseUrl);
    client.DefaultRequestHeaders.Add("User-Agent", "Aspire");
});

builder.Services.AddTransient<WeatherForecastManager>();

builder.Services.Configure<JsonOptions>(o => o.SerializerOptions.Converters.Add(new JsonStringEnumConverter()));
builder.Services.Configure<MvcJsonOptions>(o => o.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

// Add services to the container.
builder.Services.AddProblemDetails();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

app.MapGet("/weather-forecast", async (
        WeatherForecastManager weatherForecastManager,
        [FromQuery] string town)
    => Results.Ok(await weatherForecastManager.Get(town)))
.WithName("GetWeatherForecast");

app.MapDefaultEndpoints();

app.Run();