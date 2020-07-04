using Kolokwium2.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Services
{
    public interface IFireBrigadeDbService
    {
        public ICollection<FirefightersResponseDto> GetActions(int id);
    }
}
