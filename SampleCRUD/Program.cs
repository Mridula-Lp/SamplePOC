using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SampleCRUD.DataModel.Data;
using SampleCRUD.Repository.Abstract;
using SampleCRUD.Repository.Concrete;
using SampleCRUD.Service;
using SampleCRUD.Service.Abstract;
using SampleCRUD.Service.Concrete;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<SampleCRUDContext>(options =>
    options.UseSqlServer(connectionString));


#region Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
             .AddEntityFrameworkStores<SampleCRUDContext>()
             .AddDefaultTokenProviders();

//builder.Services.AddIdentityServer().AddApiAuthorization<ApplicationUser, MindsetContext>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.User.RequireUniqueEmail = true;
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 8;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = true;
});
#endregion

#region Dependency Injection

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddTransient<ISettingService, SettingService>();
builder.Services.AddTransient<ISettingRepository, SettingRepository>();
#endregion

#region Swagger Service
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Sample API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});
#endregion

builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(MappingProfiles)));

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    //app.UseMigrationsEndPoint();
    #region Swagger
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
    #endregion
}
else
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//app.MapGet("/", () => "Hello World!");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
//app.UseIdentityServer();
app.UseCors(builder => builder
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .SetIsOriginAllowed(_ => true)
                        .AllowCredentials()
                    );

app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapRazorPages();

app.UseWebSockets();
 
 
app.Run();
