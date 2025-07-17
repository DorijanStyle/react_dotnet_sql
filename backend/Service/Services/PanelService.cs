using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace service.services
{
    public class PanelService(BazaContext context) : IPanelService
    {
        public async Task<List<SolarPanel>> GetSolarPanels()
        {
            return await context.SolarPanels.ToListAsync();
        }
    }
}
