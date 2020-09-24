using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data.SqlClient;
using Core.Abstractions;
using Core.Abstractions.Helpers;
using Common.Helpers;
using Data.Repositories;
using Core.Validators.PersonValidators;

namespace Infrastructure
{
    public static class InfrastructureServiceCollection
    {
        public static IServiceCollection RegisterInteractors(this IServiceCollection services)
        {
            const string interactor = "Interactor";

            return services.Scan(selector => selector
                .FromAssembliesOf(typeof(IRequestHandler<,>))
                    .AddClasses(typeFilter => typeFilter.Where(t => t.Name.EndsWith(interactor)))
                        .AsSelf()
                        .WithTransientLifetime());
        }

        public static IServiceCollection RegisterValidators(this IServiceCollection services)
        {
            const string validator = "Validator";

            return services.Scan(selector => selector
                .FromAssembliesOf(typeof(AddPersonValidator))
                .AddClasses(typeFilter => typeFilter.Where(t => t.Name.EndsWith(validator)))
                .AsImplementedInterfaces()
                .WithTransientLifetime());
        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            const string repository = "Repository";

            return services.Scan(selector => selector
                .FromAssembliesOf(typeof(PersonRepository))
                .AddClasses(typeFilter => typeFilter.Where(t => t.Name.EndsWith(repository)))
                .AsImplementedInterfaces()
                .WithTransientLifetime());
        }

        public static IServiceCollection RegisterHelpers(this IServiceCollection services, IConfiguration configuration)
        {
            const string connectionStringName = "";
            return services.AddScoped(sql => new SqlConnection(configuration.GetConnectionString(connectionStringName)));
        }

        public static IServiceCollection RegisterSendersAndHashers(this IServiceCollection services)
        {
            return services.AddScoped<ITextHasher, TextHasher>();
        }
    }
}
