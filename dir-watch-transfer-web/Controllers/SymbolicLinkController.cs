using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dir_watch_transfer_web.Entity;
using dir_watch_transfer_web.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace test.Controllers
{
    [Route("api/symbolic/link")]
    public class SymbolicLinkController : Controller
    {
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody] SymbolicLink symbolicLink)
        {
            try
            {
                SymbolicLinkUtility symbolicLinkUtil = new SymbolicLinkUtility();

                await symbolicLinkUtil.AddAsync(symbolicLink);

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
                SymbolicLinkUtility symbolicLinkUtil = new SymbolicLinkUtility();

                List<SymbolicLink> symbolicLinks = await symbolicLinkUtil.ListAllAsync();

                return StatusCode(200, symbolicLinks);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
