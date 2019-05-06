using System;
using System.Threading.Tasks;
using DirWatchTransfer.Core.Model;
using DirWatchTransfer.Core.Utility;
using Microsoft.AspNetCore.Mvc;

namespace DirWatcherTransfer.Api.Controllers
{
    [ApiController]
    [Route("api/log")]
    public class LogController : ControllerBase
    {
        [HttpGet]
        [Route("open/directory")]
        public IActionResult OpenDirectory()
        {
            try
            {
                LogUtility.OpenDirectory();

                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetLog()
        {
            try
            {
                string content = await LogUtility.GetLog();

                return StatusCode(200, new StringResult()
                {
                    Value = content
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
