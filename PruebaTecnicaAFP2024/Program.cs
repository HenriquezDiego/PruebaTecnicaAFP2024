using Microsoft.EntityFrameworkCore;
using PruebaTecnicaAFP2024.DataAccess;
using PruebaTecnicaAFP2024.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Configuration.AddUserSecrets<Program>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = builder.Configuration;

builder.Services.AddDbContext<AppDbContext>(cfg =>
{
    cfg.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), optionsBuilder =>
    {
        optionsBuilder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
    });
});


builder.Services.AddTransient<IColorRepository>(provider =>
{
    var dbContext = provider.GetRequiredService<AppDbContext>();
    return new ColorRepository(dbContext);
});
builder.Services.AddTransient<IMarcaRepository>(provider =>
{
    var dbContext = provider.GetRequiredService<AppDbContext>();
    return new MarcaRepository(dbContext);
});
builder.Services.AddTransient<IVehiculoRepository>(provider =>
{
    var dbContext = provider.GetRequiredService<AppDbContext>();
    return new VehiculoRepository(dbContext);
});


builder.Services.AddAutoMapper(typeof(Program));

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
