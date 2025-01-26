using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Core.Interfaces.Services
{
    public interface IBookingsService
    {
        Task<List<Bookings>> GetAllBookings();
        Task<Bookings> GetByIdBooking(int id);
        Task<bool> UpdateBooking(int id, string bookingCode, string bookingDate, string totalPrice, string statusId);
        Task<bool> DeleteBooking(int id);
        Task<bool> CreateBooking(Bookings bookings);
       
    }
}
