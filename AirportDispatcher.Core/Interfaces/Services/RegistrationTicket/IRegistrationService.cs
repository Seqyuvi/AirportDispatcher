using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Core.Interfaces.Services
{
    public interface IRegistrationService
    {
        Task<bool> CreateRegistration(Registration registration);
        Task<bool> UpdateRegistration(int id, int statusId);
        Task<List<Registration>> GetAllRegistration();
        Task<bool> DeleteRegistration(int statusId);
    }
}
