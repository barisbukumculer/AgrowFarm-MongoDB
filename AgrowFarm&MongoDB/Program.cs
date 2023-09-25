using AgrowFarm_MongoDB.Services.About;
using AgrowFarm_MongoDB.Services.Banner;
using AgrowFarm_MongoDB.Services.OurService;
using AgrowFarm_MongoDB.Services.Statistic;
using AgrowFarm_MongoDB.Services.Testimonial;
using AgrowFarm_MongoDB.Services.VideoBanner;
using AgrowFarm_MongoDB.Services.WhyUs;
using AgrowFarm_MongoDB.Settings;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));

builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IBannerService, BannerService>();
builder.Services.AddScoped<IOurServiceService, OurServiceService>();
builder.Services.AddScoped<IStatisticService, StatisticService>();
builder.Services.AddScoped<ITestimonialService, TestimonialService>();
builder.Services.AddScoped<IVideoBannerService, VideoBannerService>();
builder.Services.AddScoped<IWhyUsService, WhyUsService>();

builder.Services.AddSingleton<IDatabaseSettings>(sp =>
{
	return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});

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
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();