using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AirportDispatcher.Core.Interfaces.Repositories;
using AirportDispatcher.Core.Interfaces.Services;
using AirportDispatcher.Infrastructure.Repositories;
using AirportDispatcher.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AirportDispatcher.App
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider _serviceProvider;
        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();
            services.AddScoped<IBookingsRepository, BookingsRepository>();
            services.AddScoped<IFlightsRepository, FlightsRepository>();
            services.AddScoped<IBookingTicketsRepository, IBookingTicketsRepository>();
            services.AddScoped<IGatesRepository, IGatesRepository>();
            services.AddScoped<IBagageRepository, BagageRepository>();
            services.AddScoped<IRegistrationRepository, RegistrationRepository>();
            services.AddScoped<ITicketSellingRepository, TicketSellingRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();


            services.AddScoped<IBookingsService, BookingsService>();
            services.AddScoped<IFlightsService, FlightsService>();
            services.AddScoped<IBookingTicketsService, IBookingTicketsService>();
            services.AddScoped<IGatesService, IGatesService>();
            services.AddScoped<IBagageService, BagageService>();
            services.AddScoped<IRegistrationService, RegistrationService>();
            services.AddScoped<ITicketSellingService, TicketSellingService>();
            services.AddScoped<IAuthService, AuthService>();

            
        }
    }
}
