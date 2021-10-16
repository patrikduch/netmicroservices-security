using System.Collections.Generic;
using Items.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Items.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetMovieList()
        {
            var resultList = new List<Item>();

            resultList.Add(new Item
            {
                Id = 1,
                Title = "Test title",
            });

            return Ok(resultList);
        }
    }
}
