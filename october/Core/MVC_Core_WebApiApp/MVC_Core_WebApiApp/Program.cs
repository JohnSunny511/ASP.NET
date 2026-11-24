var builder = WebApplication.CreateBuilder(args);      //Buld the application using CreateBuilder function and give it to the object "builder", to this builder we add services


var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";         //myAllowSeocificationOrigins is an object to which the cors is set
builder.Services.AddCors(options =>                             // One of the services added to builder is AddCors
{
    options.AddPolicy(name: MyAllowSpecificOrigins, builder =>
    {
        builder.WithOrigins("http://localhost:5024", "*", "*");
    });
});


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();                    // Build  the builder and created the object app

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();                          //Setting the things in app that is required to run the program
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);            //use this to run the project

app.UseAuthorization();

app.MapControllers();

app.Run();
