using Microsoft.EntityFrameworkCore;
using MVC_Ftb;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


//builder.Services.addDbContext<>

builder.Services.AddDbContext<AppDbContext>(opt =>{
    opt.UseSqlServer("Server=MSI;Database=MVCBB206;Trusted_Connection=True");

});



var app = builder.Build();

app.MapControllerRoute(


    name: "default",
    pattern: "{Controller=home}/{Action=index}");

app.UseStaticFiles();

app.Run();
