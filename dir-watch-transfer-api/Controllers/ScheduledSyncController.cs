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
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody] ScheduledSync scheduledSync)
        {
            try
            {
                ScheduledSyncRepository scheduledSyncRepo = new ScheduledSyncRepository();
                await scheduledSyncRepo.AddAsync(scheduledSync);
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
                ScheduledSyncRepository scheduledSyncRepo = new ScheduledSyncRepository();
                List<ScheduledSync> scheduledSyncs = await scheduledSyncRepo.ListAllAsync();
                return StatusCode(200, scheduledSyncs);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
