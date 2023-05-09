using _11.IdentityUygulama.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyCompany.Management.Service.Configurations;
using MyCompany.Management.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<NorthwindContext>((opt) =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("HomeNorthwind"));
    //opt.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings")["HomeNorthwind"].ToString());
});

builder.Services
    .AddIdentity<IdentityUser, IdentityRole>(opt =>
    {
        opt.Password.RequiredLength = 1;
        opt.Password.RequireDigit = false;
        opt.Password.RequireLowercase = false;
        opt.Password.RequireUppercase = false;
        opt.Password.RequireNonAlphanumeric = false;
    })
    .AddEntityFrameworkStores<NorthwindContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication(
opt =>
{
    opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
});


builder.Services.AddSingleton(builder.Configuration.GetSection("EmailConfig").Get<EmailConfig>());

builder.Services.AddScoped<IEmailService, EMailService>();

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

/*
//FONKSÝYON (COMMAND - KOMUT)
Scaffold-DbContext

//2 TANE POSITIONAL ARGUMENT (ZORUNLU ARGÜMAN YOLLAMAK ZORUNDASIN)
Connection => "Server=.\SQLEXPRESS;Database=NorthwindDB;Trusted_Connection=True;TrustServerCertificate=True; " 
Provider => Microsoft.EntityFrameworkCore.SqlServer 

//OPTIONAL(TERCÝHE BAÐLI) ARGUMENTS (DEFAULT ARGUMENTS)
-T Categories,Customers,Employees,Orders,OrderDetails,Products,Regions,Shippers,Suppliers,Territories,EmployeeTerritories 
	
-OutputDir 
Context 



Scaffold-DbContext "Server=.\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -T Categories,Customers,Employees,Orders,OrderDetails,Products,Regions,Shippers,Suppliers,Territories,EmployeeTerritories -OutputDir Context
*/
