
using WebApplicationDay3;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseWelcomePage();
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//}
//app.UseStaticFiles();
//app.UseStatusCodePages();   
app.UseMiddleware();
//app.UseRouting();

//app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
   pattern: "{controller=Home}/{action=Index}/{id?}");
//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Before Invoke from 1st app.Use()\n");
//    await next();
//    await context.Response.WriteAsync("After Invoke from 1st app.Use()\n");
//});



//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Before Invoke from 2nd app.Use()\n");
//    await next();
//    await context.Response.WriteAsync("After Invoke from 2nd app.Use()\n");
//});



//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Hello from 1st app.Run()\n");
//});



////the following will never be executed    
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Hello from 2nd app.Run()\n");
//});



// app.Map("/m1", appMap =>
//{
//    appMap.Run(async context =>
//    {
//        await context.Response.WriteAsync("Hello from  app.Map()");
//    });
//});
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Hello from app.Run()");
//});


app.Run();
