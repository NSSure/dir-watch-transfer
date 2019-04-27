using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DirWatchTransfer.Core.Entity;
using DirWatchTransfer.Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DirWatchTransfer.Api.Controllers
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
                SymbolicLinkRepository symbolicLinkRepo = new SymbolicLinkRepository();
                await symbolicLinkRepo.AddAsync(symbolicLink);
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
                // await DirWatchTransferApp.FileSystemProxyHub.Invoke("FileCopied", @"c:\", @"e:\");
                // await DirWatchTransferApp.HubConnection.InvokeAsync("FileCopied");
                // await this.hub.Clients.All.SendAsync("FileCopied");

                SymbolicLinkRepository symbolicLinkRepo = new SymbolicLinkRepository();
                List<SymbolicLink> symbolicLinks = await symbolicLinkRepo.ListAllAsync();
                return StatusCode(200, symbolicLinks);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
