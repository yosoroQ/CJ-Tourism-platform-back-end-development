using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03NET___CJ_ASP_Travel3.Controllers
{
    [Route("api/shoudongapi")]
    //[Controller]
    //public class ShoudongAPIController
    public class ShoudongAPI : Controller
    {
        [HttpGet]
        public  IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
