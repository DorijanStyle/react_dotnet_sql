using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public interface IPanelService
    {
        Task<List<SolarPanel>> GetSolarPanels();
        Task<SolarPanel> GetSolarPanelById(int id);
        Task DeleteSolarPanel(int id);
    }
}
