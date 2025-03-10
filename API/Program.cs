using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>(opt => 
{
 opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline (Referred as middleware)
app.UseCors(opt => 
{
   opt.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:3000");
});

app.MapControllers();

//Middleware ends here (everything we add above for HTTP request pipeline is part of the middleware)

//call DbInitializer class method here before the app runs

DbInitializer.InitDb(app);



app.Run();
