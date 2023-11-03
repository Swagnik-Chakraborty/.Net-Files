using Dependency.interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddSingleton(typeof(IStudentRepository), typeof(TestStudentRepository));
builder.Services.AddSingleton(typeof(IEmployeeRepository), typeof(TestEmployeeRepository));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=GetAllEmployeeDetails}/{id?}");

app.Run();
