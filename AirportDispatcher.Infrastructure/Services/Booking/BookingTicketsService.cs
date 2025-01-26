using AirportDispatcher.Core.Interfaces.Services;
using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Infrastructure.Services
{
    public class BookingTicketsService : IBookingTicketsService
    {
        /// <summary>
        /// Бизнес-логика создания соединения билета и бронирования
        /// </summary>
        /// <param name="bookingTickets"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> CraeateBookingTicket(BookingTickets bookingTickets)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Бизнес-логика удаления соединения
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> DeleteBookingTicket(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Бизнес-логика получения всех броинрований с билетами
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<BookingTickets>> GetAllBookingTicket()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Бизнес-логика обновления бронирования к билету
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bookingId"></param>
        /// <param name="ticketSellingId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> UpdateBookingTicket(int id, int bookingId, int ticketSellingId)
        {
            throw new NotImplementedException();
        }
    }
}
