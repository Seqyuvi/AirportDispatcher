using AirportDispatcher.Core.Interfaces.Repositories;
using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Infrastructure.Repositories
{
    internal class GatesRepository : IGatesRepository
    {
        /// <summary>
        /// Работа с БД. Получение всех гейтов
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<Gates>> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Работа с БД. Получение гейта по его номеру
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<Gates> GetByNumber(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Работа с БД. Обновление гейта по его номеру. Обновление статуса
        /// </summary>
        /// <param name="GateNumber"></param>
        /// <param name="idStatus"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> Update(string GateNumber, int idStatus)
        {
            throw new NotImplementedException();
        }
    }
}
