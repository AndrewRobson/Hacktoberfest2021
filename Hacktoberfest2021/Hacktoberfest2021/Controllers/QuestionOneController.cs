using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hacktoberfest2021.Controllers
{
    [Route("api/[controller]")]
    public class QuestionOneController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<int> Get()
        {
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> resultQuery =
                from number in numbers
                where number % 2 == 0
                select number;
            return resultQuery;
        }
    }
}
