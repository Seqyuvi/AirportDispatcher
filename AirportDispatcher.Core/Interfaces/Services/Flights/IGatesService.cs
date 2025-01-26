using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Core.Interfaces.Services
{
    public interface IGatesService
    {
        Task<List<Gates>> GetAllGates();
        Task<Gates> GetByNumberGates(int id);
        Task<bool> UpdateGates(string GateNumber, int idStatus);
    }
}
