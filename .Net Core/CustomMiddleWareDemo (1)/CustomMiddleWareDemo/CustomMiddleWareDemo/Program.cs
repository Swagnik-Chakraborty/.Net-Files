using CustomMiddleWareDemo.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
//services.AddTransient<MyCustomMiddleware1>()


builder.Services.AddSession();
var app = builder.Build();

app.UseSession();

app.UseMiddleware<AuthenticationMiddleware>();

app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

//app.MapGet("/", () => "Hello World!");

app.Run();
