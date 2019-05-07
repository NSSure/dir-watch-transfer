using System;
using System.Threading.Tasks;
using DirWatchTransfer.Core.DB;
using DirWatchTransfer.Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DirWatchTransfer.Core.Controllers
{
    [ApiController]
    [Route("api/settings")]
    public class SettingsController : ControllerBase
    {
        private readonly SettingsRepository settingsRepo;

        public SettingsController(SettingsRepository settingsRepo)
        {
            this.settingsRepo = settingsRepo;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return StatusCode(200, await this.settingsRepo.FirstOrDefaultAsync());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("destructive/database/reinitialize")]
        public async Task<IActionResult> ReinitializeDatabase()
        {
            try
            {
                await DirWatchTransferContext.ReinitializeDatabase();
                return StatusCode(200, await this.settingsRepo.FirstOrDefaultAsync());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
