using dependencyInjectionExample.entity;
using dependencyInjectionExample.interfaces;
using dependencyInjectionExample.provider;
using dependencyInjectionExample.repositories;
using dependencyInjectionExample.repositories.interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace dependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var eventService = serviceProvider.GetService<IUserProvider>();

            User user = new User();

            try
            {
                user.NewUser("loremipsum@gmail.com", "12345", "Murilo", "Fuscolin");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            eventService.addUser(user);
        }
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IUserProvider, UserProvider>();   
            services.AddScoped<IUserRepository, UserRepository>();      
        }
    }
}
