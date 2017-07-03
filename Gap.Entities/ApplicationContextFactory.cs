using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace Gap.Entities
{
    public class ApplicationContextFactory : IDbContextFactory<ApplicationContext>
    {
        private readonly IConfigurationRoot _configuration;

        public ApplicationContextFactory(IConfigurationRoot configuration)
        {
            _configuration = configuration;
        }
        
        public ApplicationContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<ApplicationContext>();
            builder.UseSqlServer(_configuration.GetConnectionString("Default"));

            return new ApplicationContext(builder.Options);
        }
    }
}