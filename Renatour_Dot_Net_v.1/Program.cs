using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Renatour_Dot_Net_v._1.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Renatour_Dot_Net_v_1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Renatour_Dot_Net_v_1Context") ?? throw new InvalidOperationException("Connection string 'Renatour_Dot_Net_v_1Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Destinos}/{action=Index}/{id?}");

app.Run();
