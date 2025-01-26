using AirportDispatcher.Core.Interfaces.Repositories;
using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Infrastructure.Repositories
{
    public class TicketSellingRepository : ITicketSellingRepository
    {
        public Task<bool> Create(TicketsSelling tickets)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int numberTicket)
        {
            throw new NotImplementedException();
        }

        public Task<List<TicketsSelling>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TicketsSelling> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
