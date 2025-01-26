using AirportDispatcher.Core.Interfaces.Repositories;
using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Infrastructure.Repositories
{
    public class FlightsRepository : IFlightsRepository
    {
        /// <summary>
        /// Работа с БД. Создание(добавление) рейса
        /// </summary>
        /// <param name="flights"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> Create(Flights flights)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Работа с БД. Удаление рейса по его id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Работа с БД. Удаление всез рейсов сразу
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> DeleteAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Работа с БД. Получение списка всех авиарейсов
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<Flights>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
