using Kolokwium2.DTO.Request;
using Kolokwium2.DTO.Response;
using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Services
{
    public class FireBrigadeDbService : IFireBrigadeDbService
    {
        private readonly FireBrigadeDbContext _context;

        public FireBrigadeDbService(FireBrigadeDbContext context)
        {
            _context = context;
        }

        public ICollection<FirefightersResponseDto> GetActions(int id)
        {

            if (!_context.Firefighters.Any(e => e.IdFirefighter == id))
            {
                throw new InvalidOperationException("Firefighter does not exist");
            }

            ICollection<FirefightersResponseDto> response = new Collection<FirefightersResponseDto>();

            //Firefighter firefighter = _context.Firefighters.Where(e => e.IdFirefighter == id).First();

            var actions = _context.Firefighters
                .Join(_context.FirefighterActions, f => f.IdFirefighter, fa => fa.IdFirefighter, (f, fa) => new
                {
                    f,
                    fa
                })
                .Select(ffa => new
                {
                    ffa.fa.IdAction
                })
                .Join(_context.Actions, ffa => ffa.IdAction, a => a.IdAction, (ffa, a) => new
                {
                    ffa,
                    a
                })
                .Select(ffaa => new
                {
                    ffaa.a.IdAction,
                    ffaa.a.StartTime,
                    ffaa.a.EndTime
                })
                .OrderByDescending(order => order.EndTime)
                .ToList();

            foreach(var i in actions)
            {
                response.Add(new FirefightersResponseDto
                {
                    IdAction = i.IdAction,
                    StartTime = i.StartTime,
                    EndTime = i.EndTime
                });
            }
            return response;
            
        }

        public FireTruckPostResponseDto PostFireTruck(FireTruckRequestDto firetruck)
        {
            if(firetruck == null)
            {
                throw new InvalidOperationException("Firetruck cannot be null");
            }

            if(!(_context.FireTrucks.Any(e => e.IdFireTruck == firetruck.IdFireTruck)))
            {
                throw new InvalidOperationException("Firetruck does not exist");
            }
            if (!(_context.Actions.Any(a => a.IdAction == firetruck.IdAction)))
            {
                throw new InvalidOperationException("Action does not exist");
            }
            
            var fireTruckCheck = _context.FireTrucks.Join()

            //sprawdza czy istnieje jakikolwike wolny firetruck -> czy jest wolny / czy jest potrzebny specjalny sprzet

            // 

            // 

            return null;
        }
}
