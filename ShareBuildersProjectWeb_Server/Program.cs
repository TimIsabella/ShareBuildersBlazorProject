using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using ShareBuildersProject_Business.Repository;
using ShareBuildersProject_Business.Repository.Composites;
using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Data;
using ShareBuildersProjectWeb_Api.Services;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();

//Dependancy injection
builder.Services.AddScoped<IAffiliateRepository, AffiliateRepository>();
builder.Services.AddScoped<IBroadcastTypeRepository, BroadcastTypeRepository>();
builder.Services.AddScoped<IMarketRepository, MarketRepository>();
builder.Services.AddScoped<IStationRepository, StationRepository>();
builder.Services.AddScoped<IStationCompositeRepository, StationCompositeRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserCompositeRepository, UserCompositeRepository>();

builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<StationService>();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));   //Add DbContext and configure SQL with connection string from 'appsettings.json'

builder.Services.AddMudServices(); //MudBlazor

var app = builder.Build();

// Configure the HTTP request pipeline.
if(!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();					//Set to SignalR
app.MapFallbackToPage("/_Host");	//Initial page to call: '_Host.cshtml'

app.Run();
