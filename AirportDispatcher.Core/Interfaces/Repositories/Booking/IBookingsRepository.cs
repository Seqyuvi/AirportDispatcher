using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Core.Interfaces.Repositories
{
    public interface IBookingsRepository
    {
        Task<List<Bookings>> GetAll();
        Task<Bookings> Get(int id);
        Task<bool> Update(int id, string bookingCode, string bookingDate, string totalPrice, string statusId);
        Task<bool> Delete(int id);
        Task<bool> Create(Bookings booking);
    }
}
