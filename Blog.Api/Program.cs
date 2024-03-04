using Blog.Domain.Services.Implementations;
using Blog.Domain.Services.Interfaces;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
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

