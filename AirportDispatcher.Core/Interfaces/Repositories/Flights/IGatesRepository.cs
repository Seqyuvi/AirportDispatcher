using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Core.Interfaces.Repositories
{
    public interface IGatesRepository
    {
        Task<List<Gates>> GetAll();
        Task<Gates> GetByNumber(int id);
        Task<bool> Update(string GateNumber, int idStatus);
    }
}
