using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VotingWeb.Controllers
{
    [Produces("application/json")]
    [Route("api/Votes")]
    public class VotesController : Controller
    {
        public IActionResult Get()
        {
            List<KeyValuePair<string,int>>  votes=new List<KeyValuePair<string, int>>();

            votes.Add(new KeyValuePair<string, int>("披萨",3));

            votes.Add(new KeyValuePair<string, int>("冰淇淋",4));
            return Json(votes);


        }
    }
}