using WS.InfraStructure.DBConexion;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
var conexion = builder.Configuration.GetConnectionString("ConexionSql");
builder.Services.AddSingleton(new DBConnectionFactory(conexion!));


builder.Services.AddCors(op =>
{
    op.AddPolicy("Allow", policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();       
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(s =>
{
    s.SwaggerEndpoint("/swagger/v1/swagger.json","Api de Wolf Services");
    s.RoutePrefix = string.Empty;
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
}

app.UseAuthorization();

app.UseCors("Allow");
app.MapControllers();

app.Run();
