using BlogApi.Application.Interfaces.Services;
using BlogApi.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlogApi.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IPostService, PostService>();
        return services;
    }
}
