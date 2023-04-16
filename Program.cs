using Microsoft.EntityFrameworkCore;
using padrao.Data;
using padrao.Repositories;
using padrao.Repositories.Interfaces;


var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins,
                      policy  =>
                      {
                          policy.WithOrigins("http://localhost:4200")
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                      });
});


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<UsuarioDBContex>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("Database")));

builder.Services.AddScoped<IUsuariosRepository, UsuarioRepository>();

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<ImpostosDBContex>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("Database")));

builder.Services.AddScoped<IImpostosRepository, ImpostoRepository>();

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<ServiceDBContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("Database")));

builder.Services.AddScoped<IServiceRepository, ServiceRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);


app.UseAuthorization();

app.MapControllers();

app.Run();
