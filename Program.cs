using BlazorShop.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddDbContext<BlazorShopDbContext>();
    builder.Services.AddRazorPages();
    builder.Services.AddServerSideBlazor();
}

var app = builder.Build();
{
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error");
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseRouting();

    app.MapBlazorHub();
    app.MapFallbackToPage("/_Host");

    app.Run();
}