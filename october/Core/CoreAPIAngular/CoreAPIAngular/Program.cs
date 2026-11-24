var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
//builder.Services.AddCors(Options =>
//{
//    Options.AddPolicy(MyAllowSpecificOrigins, policy =>
//    {
//        policy.WithOrigins("http://localhost:4200")              //this localhost is used for angular
//        .AllowAnyHeader()
//        .AllowAnyMethod();
//    });
//});



builder.Services.AddCors(Options =>
{
    Options.AddPolicy(MyAllowSpecificOrigins, policy =>
    {
        policy.WithOrigins("http://localhost:3000")               //this localhost is used for next.js
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});






builder.Services.AddAuthorization();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(MyAllowSpecificOrigins);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
