using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Service.Services
{
    public class PanelService(BazaContext context) : IPanelService
    {
        public async Task<List<SolarPanel>> GetSolarPanels()
        {
            return await context.SolarPanels.ToListAsync();
        }

        public async Task<SolarPanel> GetSolarPanelById(int id)
        {
            var result = await context.SolarPanels.FindAsync(id);

            if (result == null)
                throw new KeyNotFoundException($"{id}");

            return result;
        }

        public async Task DeleteSolarPanel(int id)
        {
            var result = await context.SolarPanels.FindAsync(id);

            if (result == null)
                throw new KeyNotFoundException($"{id}");

            context.SolarPanels.Remove(result);
            await context.SaveChangesAsync();
        }
    }
}
