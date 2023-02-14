using Catalog.API.Data;
using Catalog.API.Data.Interfaces;
using Catalog.API.Repositories;
using Catalog.API.Repositories.Interfaces;
using Catalog.API.Settings;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.Configure<CatalogDbSettings>(builder.Configuration.GetSection(nameof(CatalogDbSettings)));
builder.Services.AddSingleton<ICatalogDbSettings>(sp => sp.GetRequiredService<IOptions<CatalogDbSettings>>().Value);
builder.Services.AddTransient<ICatalogContext, CatalogContext>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();

builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI
        (
            s => s.SwaggerEndpoint("/swagger/v1/swagger.json", "Catalog API v1")
        );
}

app.UseAuthorization();

app.MapControllers();

app.Run();
