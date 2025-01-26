using AirportDispatcher.Core.Interfaces.Services;
using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Infrastructure.Services
{
    public class GatesService : IGatesService
    {
        /// <summary>
        /// Бизнес-логика получения гейтов
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<Gates>> GetAllGates()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Бизнес-логика получения гейта по его номеру
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<Gates> GetByNumberGates(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Бизнес-логика обновления статуса гейта по его номеру
        /// </summary>
        /// <param name="GateNumber"></param>
        /// <param name="idStatus"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> UpdateGates(string GateNumber, int idStatus)
        {
            throw new NotImplementedException();
        }
    }
}
