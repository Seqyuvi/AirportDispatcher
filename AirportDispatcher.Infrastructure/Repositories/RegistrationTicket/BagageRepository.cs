using AirportDispatcher.Core.Interfaces.Repositories;
using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Infrastructure.Repositories
{
    public class BagageRepository : IBagageRepository
    {
        /// <summary>
        /// Работа с БД. Создание багажа
        /// </summary>
        /// <param name="bagage"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> Create(Bagage bagage)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Работа с БД. Удаление багажа
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Работа с БД. Обновление багажа
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> Update(int id, int count, int weight)
        {
            throw new NotImplementedException();
        }
    }
}
