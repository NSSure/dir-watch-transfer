using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DirWatchTransfer.Core.Entity;
using DirWatchTransfer.Core.Repository;
using DirWatchTransfer.Core.Utility;
using Microsoft.AspNetCore.Mvc;

namespace DirWatchTransfer.Core.Controllers
{
    [ApiController]
    [Route("api/watcher")]
    public class WatcherController : ControllerBase
    {
        private readonly WatcherRepository watcherRepo;
        private readonly FileSystemWatcherUtility fileSystemWatcherUtil;

        public WatcherController(WatcherRepository watcherRepository, FileSystemWatcherUtility fileSystemWatcherUtil)
        {
            this.watcherRepo = watcherRepository;
            this.fileSystemWatcherUtil = fileSystemWatcherUtil;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody] Watcher watcher)
        {
            try
            {
                await this.watcherRepo.AddAsync(watcher);
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
                List<Watcher> watchers = await this.watcherRepo.ListAllAsync();
                return StatusCode(200, watchers);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("start")]
        public async Task<IActionResult> Start([FromBody] long watcherID)
        {
            try
            {
                await this.fileSystemWatcherUtil.StartWatcher(watcherID);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("stop")]
        public async Task<IActionResult> Stop([FromBody] long watcherID)
        {
            try
            {
                await this.fileSystemWatcherUtil.StopWatcher(watcherID);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
