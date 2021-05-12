using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Restserver.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class RestServerController : ControllerBase
    {
        public RestServerController() 
        {
        }

        [HttpGet]
        public void BuscarMesero()
        {
            return;
        }

        [HttpPost]
        public bool AdicionarMesero()
        {
            return false;
        }
    }
}