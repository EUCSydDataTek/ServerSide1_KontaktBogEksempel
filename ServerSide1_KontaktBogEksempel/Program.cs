using Microsoft.AspNetCore.Mvc.Razor;
using ServerSide1_KontaktBogEksempel.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    //F�r den til at s�ge efter Partial Views i en defineret mappe
    options.PageViewLocationFormats.Add("/Pages/PartialViews/{0}" + RazorViewEngine.ViewExtension);
});

builder.Services.AddSingleton<IContactService, ContactService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
