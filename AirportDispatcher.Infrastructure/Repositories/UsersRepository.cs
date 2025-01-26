using AirportDispatcher.Core.Interfaces.Repositories;
using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Infrastructure.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        /// <summary>
        /// Работа с БД. Получение списка всех пользователей
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
