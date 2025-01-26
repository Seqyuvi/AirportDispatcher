using AirportDispatcher.Core.Interfaces.Services;
using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Infrastructure.Services
{
    public class BagageService : IBagageService
    {

        /// <summary>
        /// Бизнес-логика создания багажи и его привзяки к пассажиру
        /// </summary>
        /// <param name="bagage"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> CreateBagage(Bagage bagage)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Бизнес-логика удаления багажа
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> DeleteBagage(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Бизнес-логика обновления багажа
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> UpdateBagage(int id, int count, int weight)
        {
            throw new NotImplementedException();
        }
    }
}
