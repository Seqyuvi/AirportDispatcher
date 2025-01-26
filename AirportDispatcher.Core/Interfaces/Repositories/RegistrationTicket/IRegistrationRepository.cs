using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Core.Interfaces.Repositories
{
    public interface IRegistrationRepository
    {
        Task<bool> Create(Registration registration);
        Task<bool> Update(int id, int statusId);
        Task<List<Registration>> GetAll();
        Task<bool> Delete(int statusId);
    }
}
