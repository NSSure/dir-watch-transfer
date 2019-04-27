using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DirWatchTransfer.Core.Entity;
using DirWatchTransfer.Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DirWatchTransfer.Core.Controllers
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
                WatcherRepository watcherRepo = new WatcherRepository();
                await watcherRepo.AddAsync(watcher);
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
                WatcherRepository watcherRepo = new WatcherRepository();
                List<Watcher> watchers = await watcherRepo.ListAllAsync();
                return StatusCode(200, watchers);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("copy/force")]
        public async Task<IActionResult> ForceCopy([FromBody] long watcherID)
        {
            try
            {
                return StatusCode(200, true);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
