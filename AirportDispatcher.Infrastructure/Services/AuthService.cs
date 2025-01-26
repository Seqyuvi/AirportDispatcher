using AirportDispatcher.Core.Interfaces.Services;
using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        /// <summary>
        /// Бизнес-логика авторизации диспетчера аэропрта
        /// </summary>
        /// <param name="login"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> Authorization(string login, string Password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Бизнес-логика получения всех диспетчеров аэропорта
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Бизнес-логика получения диспетчера аэропрта по его логину
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<User> GetByLogin(string login)
        {
            throw new NotImplementedException();
        }
    }
}
