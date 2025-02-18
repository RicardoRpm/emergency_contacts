using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Application.Mappings;
using Application.Services;
using Application.UseCases.Publicador;
using AutoMapper;
using Infrastruture.Contexts;
using Infrastruture.Repositories;
using Microsoft.EntityFrameworkCore;

namespace NSSUI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add connection of entity framework
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("nss")));

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        // Auto Mapper Configurations
        var mappingConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new DomainToDTOMappingProfile());
        });

        IMapper mapper = mappingConfig.CreateMapper();
        builder.Services.AddSingleton(mapper);

        // Dependecy Injection
        builder.Services.AddScoped<IPublicadorService, PublicadorService>();
        builder.Services.AddScoped<IPublicadorRepository, PublicadorRepository>();
        builder.Services.AddScoped<GetAllPublicadores>();
        builder.Services.AddScoped<AddPublicador>();
        
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see
            // https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
    }
}