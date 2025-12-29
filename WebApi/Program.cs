using WebApi.InyeccionDeDependencias.Loggers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//if (!app.Environment.IsDevelopment())
//{
builder.Services.AddScoped<IMilogger>((IServiceProvider serviceProvider) =>
{
    var env = serviceProvider.GetService<Microsoft.AspNetCore.Hosting.IWebHostEnvironment>();
    //var env = serviceProvider.GetService<Microsoft.AspNetCore.Hosting.IHostingEnvironment>();
    if (env.IsDevelopment())
    {
        return new LoggerConsola();
    }
    else
    {
        return new LoggerEnArchivo();
    }
});
//}


var app = builder.Build();



// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
