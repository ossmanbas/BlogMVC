using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Proje seviyesinde Authorize iþlemi -->

builder.Services.AddSession();
builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
    config.Filters.Add(new AuthorizeFilter(policy));


});
// <-- Proje seviyesinde Authorize iþlemi 

//Oturum AÇ sayfasýna yönlendirme -->
builder.Services.AddMvc();
builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(x=>
    {
        x.LoginPath = "/Login/Index/";
    }

    );
// <-- Oturum AÇ sayfasýna yönlendirme


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
app.UseAuthentication();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
app.UseSession();
app.UseRouting();

app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}"); //Herhangi bir 404 hatasý alýndýðýnda yönlendirelecek sayfa

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
