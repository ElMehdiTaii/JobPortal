using JobPortal.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JobPortal.Entities
{
    public static class EntitiesRegistrySrevice
    {
        public static IServiceCollection ConfigureEntitiesRegistrySrevice(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionStrings:DefaultConnection"];
            
            services.AddDbContext<RepositoryContext>(o => o.UseSqlServer(connectionString));
            
            return services;
        }
    }
}
