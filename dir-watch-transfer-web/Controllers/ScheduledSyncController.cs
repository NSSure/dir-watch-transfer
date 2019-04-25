using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DirWatchTransfer.Entity;
using DirWatchTransfer.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace test.Controllers
{
    [Route("api/scheduled/sync")]
    public class ScheduledSyncController : Controller
    {
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody] ScheduledSync scheduledSync)
        {
            try
            {
                ScheduledSyncUtility scheduledSyncUtil = new ScheduledSyncUtility();
                await scheduledSyncUtil.AddAsync(scheduledSync);
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
                ScheduledSyncUtility scheduledSyncUtil = new ScheduledSyncUtility();
                List<ScheduledSync> scheduledSyncs = await scheduledSyncUtil.ListAllAsync();
                return StatusCode(200, scheduledSyncs);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
