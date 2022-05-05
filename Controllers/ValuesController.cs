using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Index()
        {
            return new string[] { "values1", "values2", "values3", "values4" };
        }

        [HttpGet("{id  }")]
        public string Get(int id)
        {
            return "the value is " + id;
        }
    }
}
