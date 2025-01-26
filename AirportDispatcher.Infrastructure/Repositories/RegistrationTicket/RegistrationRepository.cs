using AirportDispatcher.Core.Interfaces.Repositories;
using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Infrastructure.Repositories
{
    public class RegistrationRepository : IRegistrationRepository
    {
        /// <summary>
        /// Работа с БД. Создание регистрации на рейс
        /// </summary>
        /// <param name="registration"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> Create(Registration registration)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Работа с БД. Удаление регистрации на рейс
        /// </summary>
        /// <param name="statusId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> Delete(int statusId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Работа с БД. Получение всех регистраций
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<Registration>> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Работа с БД. Обновление регистрации
        /// </summary>
        /// <param name="id"></param>
        /// <param name="statusId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> Update(int id, int statusId)
        {
            throw new NotImplementedException();
        }
    }
}
