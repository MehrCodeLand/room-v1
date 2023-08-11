using LogicRoom.Services.ArtServices;
using Microsoft.EntityFrameworkCore;
using RoomLibrary.MyDb_Room;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyDb>(option =>
{
    option.UseSqlServer(
        builder.Configuration.GetConnectionString("DbStringConn")
        );
});

// scoped 
builder.Services.AddScoped<IArtRepo, ArtRepo>();


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
