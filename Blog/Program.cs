using Blog.Core.Models;
using Blog.Core.Services.Implementations;
using Blog.Core.Services.Interfaces;
using Blog.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDb"));
builder.Services.AddSingleton<MongoDbService<Post>>();
builder.Services.AddSingleton<MongoDbService<Comment>>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddControllers();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapControllers();
}

app.UseHttpsRedirection();
app.Run();

