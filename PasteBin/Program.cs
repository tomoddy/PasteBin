using Microsoft.EntityFrameworkCore;
using PasteBin.Data;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSession();

WebApplication app = builder.Build();
app.UseStaticFiles();
app.UseSession();
app.MapRazorPages();
app.Run();