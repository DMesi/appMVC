using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StorageServiceLibrary.Model;


namespace StorageServiceLibrary.Model
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
          
            services.AddDbContext<App_Data_Base>(opt => opt
                .UseSqlServer("server=(LocalDb)\\MSSQLLocalDB; database = prakticni_zadatak_baza_WM ;Integrated Security=True"));

            return services;
        }   

    }
}
