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
    public class KullanicilarController : ControllerBase
    {
        ILmcUserService _userService;

        public KullanicilarController(ILmcUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _userService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getkullanicibykullaniciid")]
        public async Task<IActionResult> GetKullaniciByKullaniciId(int userId)
        {
            var result = await _userService.GetById(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(User user)
        {
            var result = await _userService.Add(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(User user)
        {
            var result = await _userService.Update(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(User user)
        {
            var result = await _userService.Delete(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getyetkilerbykullaniciid")]
        public async Task<IActionResult> GetYetkilerByKullanici(User user)
        {

            var result = await _userService.GetClaims(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getkullanicibyemail")]
        public async Task<IActionResult> GetKullaniciByMail(string email)
        {

            var result = await _userService.GetByMail(email);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
