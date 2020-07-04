using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Services
{
    public class FireBrigadeDbService : IFireBrigadeDbService
    {
        private readonly FireBrigadeDbService _context;

        public FireBrigadeDbService(FireBrigadeDbService context)
        {
            _context = context;
        }


    }
}
