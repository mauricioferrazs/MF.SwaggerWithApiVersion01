using MF.SwaggerWithApiVersion01.Api.SwaggerWithApiVersion;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

//AddSwaggerWithApiVersionConfiguration
builder.Services.AddSwaggerWithApiVersionConfiguration();

var app = builder.Build();

app.UseHsts();

app.UseHttpsRedirection();

//UseSwaggerWithApiVersionConfiguration
app.UseSwaggerWithApiVersionConfiguration(app.Services.GetRequiredService<IApiVersionDescriptionProvider>());

app.MapControllers();

app.Run();
