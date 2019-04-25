using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DirWatchTransfer.Entity;
using DirWatchTransfer.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace test.Controllers
{
    [Route("api/watcher")]
    public class WatcherController : Controller
    {
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody] Watcher watcher)
        {
            try
            {
                WatcherUtility watcherUtil = new WatcherUtility();
                await watcherUtil.AddAsync(watcher);
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
                WatcherUtility watcherUtil = new WatcherUtility();
                List<Watcher> watchers = await watcherUtil.ListAllAsync();
                return StatusCode(200, watchers);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
