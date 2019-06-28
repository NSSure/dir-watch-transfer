using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DirWatchTransfer.Core.Entity;
using DirWatchTransfer.Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DirWatchTransfer.Api.Controllers
{
    [ApiController]
    [Route("api/symbolic/link")]
    public class SymbolicLinkController : ControllerBase
    {
        private SymbolicLinkRepository symbolicLinkRepo;

        public SymbolicLinkController(SymbolicLinkRepository symbolicLinkRepo)
        {
            this.symbolicLinkRepo = symbolicLinkRepo;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody] SymbolicLink symbolicLink)
        {
            try
            {
                await this.symbolicLinkRepo.AddAsync(symbolicLink);
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
                List<SymbolicLink> symbolicLinks = await this.symbolicLinkRepo.ListAllAsync();
                return StatusCode(200, symbolicLinks);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
