using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DirWatchTransfer.Core.Entity;
using DirWatchTransfer.Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DirWatcherTransfer.Api.Controllers
{
    [ApiController]
    [Route("api/scheduled/sync")]
    public class ScheduledSyncController : ControllerBase
    {
        private ScheduledSyncRepository scheduledSyncRepo;

        public ScheduledSyncController(ScheduledSyncRepository scheduledSyncRepo)
        {
            this.scheduledSyncRepo = scheduledSyncRepo;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody] ScheduledSync scheduledSync)
        {
            try
            {
                await this.scheduledSyncRepo.AddAsync(scheduledSync);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> List()
        {
            try
            {
                List<ScheduledSync> scheduledSyncs = await this.scheduledSyncRepo.ListAllAsync();
                return StatusCode(200, scheduledSyncs);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
