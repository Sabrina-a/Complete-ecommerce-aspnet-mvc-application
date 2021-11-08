﻿using E_Tickets.Data.Base;
using E_Tickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        /// <summary>
        /// //DI
        /// inject AppDbContext in ActorService constructor after removing it from ActorsController
        /// </summary>
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context) : base(context) { }
       


        //public async Task AddAsync(Actor actor)
        //{
        //    await _context.Actors.AddAsync(actor);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
        //    _context.Actors.Remove(result);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<IEnumerable<Actor>> GetAllAsync()
        //{
        //    var result = await _context.Actors.ToListAsync();
        //    return result;
        //}

        //public async Task<Actor> GetByIdAsync(int id)
        //{
        //    var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
        //    return result ;
        //}

        //public async Task<Actor> UpdateAsync(int id, Actor newActor)
        //{
        //    _context.Update(newActor);
        //    await _context.SaveChangesAsync();
        //    return newActor;
        //}
    }
}
