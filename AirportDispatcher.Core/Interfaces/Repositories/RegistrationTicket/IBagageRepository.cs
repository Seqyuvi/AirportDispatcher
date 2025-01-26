using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Core.Interfaces.Repositories
{
    public interface IBagageRepository
    {
        Task<bool> Create(Bagage bagage);
        Task<bool> Update(int id, int count, int weight);
        Task<bool> Delete(int id);
    }
}
