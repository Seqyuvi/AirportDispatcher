using AirportDispatcher.Core.Interfaces.Services;
using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Infrastructure.Services
{
    public class FlightsService : IFlightsService
    {
        /// <summary>
        /// Бизнес-логика создания рейса
        /// </summary>
        /// <param name="flights"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> CreateFlights(Flights flights)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Бизнес-логика удаления всех рейсов
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> DeleteAllFlights()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Бизнес-логика удаления одного рейса
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> DeleteFlights(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Бизнес-логика получения всех рейсов
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<Flights>> GetAllFlights()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Бизнес-логика получения рейса(-ов) по аэропорту прибытия
        /// </summary>
        /// <param name="titleAirport"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<Flights>> GetByArrivalAirportFlights(string titleAirport)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Бизнес-логика получения и рейса и его пассижров
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<(Flights, List<TicketsSelling>)> GetByNumberFlights(string number)
        {
            throw new NotImplementedException();
        }
    }
}
