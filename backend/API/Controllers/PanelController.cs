using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using service.services;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PanelController(IPanelService panelService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetPanels()
        {
            return Ok(await panelService.GetSolarPanels());
        }
    }
}
