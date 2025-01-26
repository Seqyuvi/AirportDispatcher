using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Core.Interfaces.Repositories
{
    public interface ITicketSellingRepository
    {
        Task<bool> Create(TicketsSelling tickets);
        Task<bool> Delete(int numberTicket);
        Task<List<TicketsSelling>> GetAll();
        Task<TicketsSelling> GetById(int id);
    }
}
