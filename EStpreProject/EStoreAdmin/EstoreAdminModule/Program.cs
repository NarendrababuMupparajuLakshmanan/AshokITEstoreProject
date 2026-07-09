
using EStoreAdminModel.ServiceContracts;
using EStoreAdminRepository.Repository;
using EStoreAdminService.Services;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

///CreateBuilder Method is used to Create an Instance of Core Application Modules
var builder = WebApplication.CreateBuilder(args);

//You are registeriing a Controllers in Bulider.Services
builder.Services.AddControllersWithViews();

//Register BrandService as an IOC
builder.Services.Add(new ServiceDescriptor(
    typeof(IBrandService),
    typeof(BrandService),
    ServiceLifetime.Transient));

string _connectionstring = builder.Configuration.GetConnectionString("EStoreAdminConnection").ToString();

//Create Object for Repository Class (BrandRepository) and Register it as an IOC
builder.Services.AddDbContext<BrandRepository>(options =>
{
    options.UseSqlServer(_connectionstring);
});

//Builder.Build is a Method is used to create all objects to realted to Web Application
//as a readonly 
var app = builder.Build();

//We need to enable static files as a Middleware Component
app.UseStaticFiles();


//Pre Defined Middleware available in Asp.Net MVC Core
app.UseRouting();
app.MapControllers();

app.Run();
