using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace Gap.Entities
{
    public class ApplicationContextFactory : IDbContextFactory<ApplicationContext>
    {
        public ApplicationContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<ApplicationContext>();
            builder.UseSqlServer(Environment.GetEnvironmentVariable("CONNECTION"));
            
            return new ApplicationContext(builder.Options);
        }
    }
}