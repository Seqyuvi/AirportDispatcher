using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Core.Interfaces.Repositories
{
    public interface IBookingTicketsRepository
    {
        Task<List<BookingTickets>> GetAll();
        Task<bool> Update(int id, int bookingId, int ticketSellingId);
        Task<bool> Delete(int id);

        Task<bool> Create(BookingTickets bookingTickets);

    }
}
