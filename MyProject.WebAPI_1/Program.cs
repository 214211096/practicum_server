using Microsoft.EntityFrameworkCore;
using MyProject.Context;
using MyProject.Repositories.Interfaces;
//using MyProject.Repositories.Interfaces;
using MyProject.Services;
using MyProject.Services.Interfaces;
using MyProject.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
//builder.Services.AddServices();
//builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddSingleton<IContext, MyDBContext>();
//builder.Services.AddDbContext<MyDBContext>();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();


//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
//app.UseCors(x => x
//           .AllowAnyOrigin()
//           .AllowAnyMethod()
//           .AllowAnyHeader());

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
builder.Services.AddControllers();
builder.Services.AddServices();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "ReactPolicy",
                      policy =>
                      {
                          policy.WithOrigins("*");
                      });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x => x
                 .AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
