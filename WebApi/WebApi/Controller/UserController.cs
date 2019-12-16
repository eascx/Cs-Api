using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller
{
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        public Task<ActionResult<object>> addUser()
        {
            return null;
        }
    }
}