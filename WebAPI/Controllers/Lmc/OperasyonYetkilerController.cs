using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/lmc/[controller]")]
    [ApiController]
    public class OperasyonYetkilerController : ControllerBase
    {
        ILmcOperationClaimService _operationClaimService;

        public OperasyonYetkilerController(ILmcOperationClaimService operationClaimService)
        {
            _operationClaimService = operationClaimService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _operationClaimService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getoperasyonyetkibyoperasyonyetkiid")]
        public async Task<IActionResult> GetOperasyonYetkiByOperasyonYetkiId(int operasyonYetkiId)
        {
            var result = await _operationClaimService.GetById(operasyonYetkiId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(OperationClaim operationClaim)
        {
            var result = await _operationClaimService.Add(operationClaim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(OperationClaim operationClaim)
        {
            var result = await _operationClaimService.Update(operationClaim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(OperationClaim operationClaim)
        {
            var result = await _operationClaimService.Delete(operationClaim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
