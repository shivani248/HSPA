using System.Configuration;
using System.Text;
using FluentAssertions.Common;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ServiceStack.Text;
using WebAPI;
using WebAPI.Data.Repo;
using WebAPI.Extension;
using WebAPI.Helpers;
using WebAPI.Interface;
using WebAPI.Interfaces;
using WebAPI.Srervices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddScoped<InterfaceUnitofWork , UnitOfWork>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddScoped<IphotoService, PhotoServices>();


var secretKey =  builder.Configuration.GetSection("AppSettings:Key").Value;
if (string.IsNullOrEmpty(secretKey))
{
    // Log an error or throw an exception indicating that the secret key is missing
    throw new InvalidOperationException("Secret key is missing or null in configuration.");
}
var key = new SymmetricSecurityKey(Encoding.UTF8
    .GetBytes(secretKey));
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opt =>
    {
        opt.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            ValidateIssuer = false,
            ValidateAudience = false,
            IssuerSigningKey = key
        };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.ConfigureExceptionHandler();
app.UseHttpsRedirection();

app.UseCors(m=>m.AllowAnyOrigin() .AllowAnyHeader().AllowAnyMethod());
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
