using Infrastructure.Persist;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DependencyInjection
{
    public static class DependencyInjection 
    {
        public static void AddPersist(this IServiceCollection services , IConfiguration configuration)
        {
            string Connection = configuration.GetConnectionString("Db");
            services.AddDbContext<DatabaseContext>(c => c.UseSqlServer(Connection));
        }



        
    }
}
