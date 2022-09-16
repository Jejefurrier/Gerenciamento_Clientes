using Gerenciamento_Clientes.Business;
using Gerenciamento_Clientes.Business.Validations;
using Gerenciamento_Clientes.DataAccess;
using Gerenciamento_Clientes.DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IClienteBusiness, ClienteBusiness>();
builder.Services.AddScoped<IClienteDataAccess, ClienteDataAccess>();
builder.Services.AddScoped<ClienteDbContext, ClienteDbContext>();
builder.Services.AddScoped<ClienteValidation, ClienteValidation>();


builder.Services.AddDbContext<ClienteDbContext>(options =>
    options.UseSqlite("Data Source=Cliente.db;"));

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
