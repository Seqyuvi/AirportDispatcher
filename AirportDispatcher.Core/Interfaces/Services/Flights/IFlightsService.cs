using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Core.Interfaces.Services
{
    public interface IFlightsService
    {
        Task<bool> CreateFlights(Flights flights);
        Task<bool> DeleteFlights(int id);
        Task<bool> DeleteAllFlights();
        Task<List<Flights>> GetAllFlights();
        Task<(Flights, List<TicketsSelling>)> GetByNumberFlights(string number);
        Task<List<Flights>> GetByArrivalAirportFlights(string titleAirport);
    }
}
