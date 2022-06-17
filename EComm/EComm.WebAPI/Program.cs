global using EComm.Core;
using EComm.Infrastructure;
using EComm.WebAPI.Auth;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddControllers();

builder.Services.AddAuthentication("MyCustomAuth")
  .AddScheme<AuthenticationSchemeOptions, MyCustomAuthHandler>
    ("MyCustomAuth", options => { });

builder.Services.AddAuthorization(options => {
    options.AddPolicy("AdminsOnly", policy =>
      policy.RequireClaim(ClaimTypes.Role, "Admin"));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
