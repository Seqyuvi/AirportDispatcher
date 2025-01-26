using AirportDispatcher.Core.Interfaces.Repositories;
using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Infrastructure.Repositories
{
    internal class BookingTicketsRepositorye : IBookingTicketsRepository
    {

        public Task<bool> Create(BookingTickets bookingTickets)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BookingTickets>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int id, int bookingId, int ticketSellingId)
        {
            throw new NotImplementedException();
        }
    }
}
