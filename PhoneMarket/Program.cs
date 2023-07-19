using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PhoneMarket.Data;
using PhoneMarket.Repository.IRepo;
using PhoneMarket.Repository.SqlRepo;
using PhoneMarket.Service.IServices;
using PhoneMarket.Service.LogicServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//db connection
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//DI
builder.Services.AddScoped<IPermissionRepo,SqlPermissionRepo>();
builder.Services.AddScoped<IPermissionService,PermissionService>();
//role di
builder.Services.AddScoped<IRoleService,RoleService>();
builder.Services.AddScoped<IRoleRepo,SqlRoleRepo>();
//phone di
builder.Services.AddScoped<IPhoneRepo,SqlPhoneRepo>();
builder.Services.AddScoped<IPhoneService,PhoneService>();
//auth
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,


        };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
