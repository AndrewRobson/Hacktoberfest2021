using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hacktoberfest2021.Controllers
{
    [Route("api/[controller]")]
    public class QuestionThree : Controller
    {
        // GET api/values/5
        [HttpGet("{number}")]
        public string Get(int number)
        {
            int[] array = new int[] { 5, 7, 13, 24, 6, 9, 8, 7 };
            if (number < 0 || number > array.Length)
            {
                return "Invalid Input";
            }
            var result = array.OrderByDescending(x => x).ToArray().Take(number);
            return JsonConvert.SerializeObject(result);
        }
    }
}
