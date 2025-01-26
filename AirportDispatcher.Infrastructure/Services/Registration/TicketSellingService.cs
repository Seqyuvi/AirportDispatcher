using AirportDispatcher.Core.Interfaces.Services;
using AirportDispatcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDispatcher.Infrastructure.Services
{
    public class TicketSellingService : ITicketSellingService
    {

        /// <summary>
        /// Бизнес-логика созданиея(покупки) билета на авиарейс 
        /// </summary>
        /// <param name="tickets"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> CreateTicket(TicketsSelling tickets)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Бизнес-логика удаление купленного билета
        /// </summary>
        /// <param name="numberTicket"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> DeleteTicket(int numberTicket)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Бизнес-логика получения всех купленных билетов
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<TicketsSelling>> GetAllTicket()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Бизнес-логика получени билета по его id(номеру)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TicketsSelling> GetByIdTicket(int id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Бизнес-логика поиска пассажира по его ФИО
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="secondName"></param>
        /// <param name="surname"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<TicketsSelling>> GetPassangerByNameTicket(string firstName, string secondName, string surname)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Бизнес-логика получения пассажира по его номеру и серии паспорта
        /// </summary>
        /// <param name="passportNumber"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TicketsSelling> GetPassangerByPassportTicket(string passportNumber)
        {
            throw new NotImplementedException();
        }
    }
}
