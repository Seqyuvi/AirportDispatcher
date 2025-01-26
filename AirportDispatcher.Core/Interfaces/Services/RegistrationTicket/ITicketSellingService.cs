using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Core.Interfaces.Services
{
    public interface ITicketSellingService
    {
        Task<bool> CreateTicket(TicketsSelling tickets);
        Task<bool> DeleteTicket(int numberTicket);
        Task<List<TicketsSelling>> GetAllTicket();
        Task<TicketsSelling> GetByIdTicket(int id);
        Task<TicketsSelling> GetPassangerByPassportTicket(string passportNumber);
        Task<List<TicketsSelling>> GetPassangerByNameTicket(string firstName, string secondName, string surname);
    }
}
