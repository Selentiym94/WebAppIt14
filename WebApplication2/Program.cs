using WebApplication2.Logic.Interfaces;
using WebApplication2.Logic.Processors;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string baseUrl = string.Empty;//builder.Configuration.GetSection("").Get<string>();
PlaceholderClient client = new PlaceholderClient(baseUrl);
builder.Services.AddSingleton<IPlaceholderClient, PlaceholderClient>(t=>client);
builder.Services.AddSingleton<PlaceholderDataProcessor>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
