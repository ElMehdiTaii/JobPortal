using JobPortal.Contracts;
using JobPortal.Entities.Models;
using JobPortal.Repositories;
using Microsoft.EntityFrameworkCore;

namespace JobPortal
{
    public static class JobPortalRegistrySrevice
    {
        public static IServiceCollection ConfigureRepositoryRegistrySrevice(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            return services;
        }
    }
}
