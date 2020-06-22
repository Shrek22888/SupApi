using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SupApi.ViewModels;

namespace SupApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        public async Task<ActionResult> Get()
        {
            var user = new UserVm("dsad", "dasdsa", "ddsad", "22222");
            await Task.Delay(1000);

            ContentResult result = new ContentResult();
            result.ContentType = "application/json";

            result.Content = JsonConvert.SerializeObject(user);
            return result;
        }
    }
}
