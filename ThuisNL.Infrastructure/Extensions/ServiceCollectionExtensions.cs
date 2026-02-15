
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ThuisNL.Infrastructure.Persistence;

namespace ThuisNL.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("ThuisNLDb");
        
        services.AddDbContext<ThuisNLDbContext>(options =>
            options.UseNpgsql(connectionString));

        return services;
    }
}