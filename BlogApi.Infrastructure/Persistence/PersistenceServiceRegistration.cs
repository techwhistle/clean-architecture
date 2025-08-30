using Microsoft.EntityFrameworkCore;
using BlogApi.Infrastructure.Repositories;
using BlogApi.Application.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace BlogApi.Infrastructure.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            // Register DbContext with PostgreSQL
            services.AddDbContext<BlogDbContext>(options =>
                options.UseNpgsql(
                    configuration.GetConnectionString("DefaultConnection")));

            // Register repositories (Scoped = per request)
            services.AddScoped<IPostRepository, PostRepository>();

            return services;
        }
    }
}
