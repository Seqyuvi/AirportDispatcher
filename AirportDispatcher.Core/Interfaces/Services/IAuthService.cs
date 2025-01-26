using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Core.Interfaces.Services
{
    public interface IAuthService
    {
        Task<List<User>> GetAll();
        Task<User> GetByLogin(string login);
        Task<bool> Authorization(string login, string Password);
    }
}
