using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.services
{
    public interface IPanelService
    {
        Task<List<SolarPanel>> GetSolarPanels();
    }
}
