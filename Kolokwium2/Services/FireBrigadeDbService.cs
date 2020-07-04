using Kolokwium2.DTO.Response;
using Kolokwium2.Models;
using System;
using System.Collections.Generic;
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

            ICollection<FirefightersResponseDto> response;

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
    }
}
