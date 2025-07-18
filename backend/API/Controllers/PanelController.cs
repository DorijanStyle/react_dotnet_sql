using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using Service.Services;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PanelController(IPanelService panelService) : ControllerBase
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetSolarPanels()
        {
            return Ok(await panelService.GetSolarPanels());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetSolarPanelById(int id)
        {
            try
            {
                return Ok(await panelService.GetSolarPanelById(id));
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteSolarPanel(int id)
        {
            try
            {
                await panelService.DeleteSolarPanel(id);
                return Ok();
            }
            catch(KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
