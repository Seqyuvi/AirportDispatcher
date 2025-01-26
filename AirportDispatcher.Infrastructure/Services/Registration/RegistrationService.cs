using AirportDispatcher.Core.Interfaces.Services;
using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Infrastructure.Services
{
    public class RegistrationService : IRegistrationService
    {
        /// <summary>
        /// Бизнес-логика регистрации пользователя на рейс 
        /// </summary>
        /// <param name="registration"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> CreateRegistration(Registration registration)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Бизнес-логика удаления регситрации на рейс пользователя
        /// </summary>
        /// <param name="statusId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> DeleteRegistration(int statusId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Бизнес-логика получения всех зарегестрированных пользователей
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<Registration>> GetAllRegistration()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Бизнес-логика обновления зарегистрированного пользователя
        /// </summary>
        /// <param name="id"></param>
        /// <param name="statusId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> UpdateRegistration(int id, int statusId)
        {
            throw new NotImplementedException();
        }
    }
}
