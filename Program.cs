using System.Reflection;
using API.Helpers;
using AspNetCoreRateLimit;
using facturacionAPI.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers( options => {

    options.RespectBrowserAcceptHeader = true;
    options.ReturnHttpNotAcceptable=true;
}).AddXmlSerializerFormatters();



// permite la validacion por roles
builder.Services.AddHttpContextAccessor();



builder.Services.AddControllers();



//-Add Authentication
builder.Services.AddAuthentication();


builder.Services.AddDbContext<ApiDbContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("ConexCampus");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add Configurations
builder.Services.AddAplicacionServices();
builder.Services.ConfigureCors();
builder.Services.ConfigurationRatelimiting();
builder.Services.ConfigureApiVersioning();
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
builder.Services.AddJwt(builder.Configuration);




builder.Services.AddAuthorization(opts =>{
    opts.DefaultPolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .AddRequirements(new GlobalVerbRoleRequirement())
        .Build();
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("CorsPolicy");
app.UseApiVersioning();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseIpRateLimiting();

app.MapControllers();

app.Run();