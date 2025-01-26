using AirportDispatcher.Core.Interfaces.Repositories;
using AirportDispatcher.Core.Interfaces.Services;
using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Infrastructure.Services
{
    public class BookingsService : IBookingsService
    {

        
        /// <summary>
        ///  Бизнес-логика создания бронирования
        /// </summary>
        /// <param name="bookings"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> CreateBooking(Bookings bookings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Бизнес-логика Удаления бронирования по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> DeleteBooking(int id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        ///  Бизнес-логика Получения списка всех бронирований
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<Bookings>> GetAllBookings()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Бизнес-логика Получения бронирования по Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<Bookings> GetByIdBooking(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Бизнес-логика Обновления бронирования
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bookingCode"></param>
        /// <param name="bookingDate"></param>
        /// <param name="totalPrice"></param>
        /// <param name="statusId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> UpdateBooking(int id, string bookingCode, string bookingDate, string totalPrice, string statusId)
        {
            throw new NotImplementedException();
        }
    }
}
