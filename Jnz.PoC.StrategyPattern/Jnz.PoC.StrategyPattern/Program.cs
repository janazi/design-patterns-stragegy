using Jnz.PoC.StrategyPattern.Strategies.Math;
using Jnz.PoC.StrategyPattern.Strategies.MathOperators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IMathOperator, AddOperator>();
builder.Services.AddSingleton<IMathOperator, SubtractOperator>();
builder.Services.AddSingleton<IMathStrategy, MathStrategy>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
