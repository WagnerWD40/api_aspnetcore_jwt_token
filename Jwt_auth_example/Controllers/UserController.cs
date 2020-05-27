using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jwt_auth_example.Models;
using Jwt_auth_example.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt_auth_example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<ActionResult> RegisterAsync(RegisterModels model)
        {
            var result = await _userService.RegisterAsync(model);

            return Ok(result);
        }
    }
}
