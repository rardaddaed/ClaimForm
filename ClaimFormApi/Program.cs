using Autofac;
using Autofac.Extensions.DependencyInjection;
using ClaimFormApi.Middleware;
using ClaimFormBusiness;
using ClaimFormRepository;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using SAOCPSEDB;
//using SAOCPSEDB.ClaimForm.Dialogs;
using SAOCPSEDB.Models;
using SAOCPSEDB.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    /*options.AddPolicy("AllowReactApp",
        builder =>
        {
            builder.WithOrigins("http://localhost:5173")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });*/
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});

builder.Services.AddControllers();
// builder.Services.AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true); // If want to allow nullable types in form submission for non nullable reference types.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Get from connection string.
// builder.Services.AddSqlServer<SbcDbContext>(builder.Configuration.GetConnectionString("DefaultConnection"));
builder.Services.AddDbContextFactory<SbcDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<SbcDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")), optionsLifetime: ServiceLifetime.Singleton);

builder.Services.AddTransient<IDataPreloadService, DataPreloadService>();
//builder.Services.AddScoped<BSBSearchDialog>();

builder.Services.AddAutoMapper(x =>
{
    x.AddProfile<MappingProfile>();
});

builder.Services.AddMediatR(c => {
  c.RegisterServicesFromAssembly(typeof(Program).Assembly);
  c.AddOpenBehavior(typeof(ValidationBehavior<,>));
});
builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterModule<BusinessModule>();
    containerBuilder.RegisterModule<RepositoryModule>();
});

var app = builder.Build();

// Preload data
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var dataPreloadService = services.GetRequiredService<IDataPreloadService>();
        await dataPreloadService.PreloadDataAsync();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while preloading the data.");
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles(new StaticFileOptions
{
    OnPrepareResponse = ctx =>
    {
        ctx.Context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        ctx.Context.Response.Headers.Add("Access-Control-Allow-Methods", "GET, OPTIONS");
        ctx.Context.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type");
    }
});

app.UseRouting();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
