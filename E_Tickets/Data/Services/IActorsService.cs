using E_Tickets.Data.Base;
using E_Tickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Data.Services
{
    public interface IActorsService : IEntityBaseRepository<Actor>
    {
        //Task<IEnumerable<Actor>> GetAllAsync();
        //Task<Actor> GetByIdAsync(int id);
        //Task AddAsync(Actor actor);
        //Task<Actor> UpdateAsync(int id, Actor newActor);
        //Task DeleteAsync(int id);
    }
}
