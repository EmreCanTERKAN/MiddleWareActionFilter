using MiddleWareActionFilter.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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

//var maintenenceMode = true;

//app.Use(async (context, next) =>
//{

//    if (maintenenceMode)
//    {
//        await context.Response.WriteAsync("Bakýmdayýz, Size yakýnda yeniden hizmet vereceðiz.");
//    }
//    else
//    {
//        await next(context);
//    }




//});

// app.UseMiddleware<MaintenenceModeMiddleware>();

app.UseMaintenenceMode();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
