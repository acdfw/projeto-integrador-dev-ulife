using Anima.ProjetoIntegrador.Infrastructure.Data.CrossCutting.IoC;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddInfrastructureData(configuration);

builder.Services.AddControllers();
builder.Services.AddAuthConfig();
builder.Services.AddSwagger();

builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddTokenGenerator();
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseRouting();

app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
