using Innovengers.UI.Components;
using Innovengers.Infrastructure.Data;
using Innovengers.Infrastructure.Repositories;
using Innovengers.Services.Interfaces;
using Innovengers.Services.Services;
using Microsoft.EntityFrameworkCore;
using Innovengers.Core.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Configure DbContext with SQL Server connection string from appsettings.json
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register repositories and services for DI
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

// Add Razor Components and interactive server components for Blazor Server
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
