using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Core.Interfaces.Repositories
{
    public interface IFlightsRepository
    {
        Task<bool> Create(Flights flights);
        Task<bool> Delete(int id);
        Task<bool> DeleteAll();
        Task<List<Flights>> GetAll();

    }
}
