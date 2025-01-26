using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Core.Interfaces.Services
{
    public interface IBookingTicketsService
    {
        Task<List<BookingTickets>> GetAllBookingTicket();
        Task<bool> UpdateBookingTicket(int id, int bookingId, int ticketSellingId);
        Task<bool> DeleteBookingTicket(int id);
        Task<bool> CraeateBookingTicket(BookingTickets bookingTickets);
    }
}
