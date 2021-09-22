using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Items.API.Model;

namespace Items.API.Controllers
{

    [ApiController]
    [Route("/api/v1/[controller]")]
    public class ItemsController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<Item>> getItemsAsync()
        {
            return null;
        }
    }
}
