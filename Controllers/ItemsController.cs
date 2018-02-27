using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PTHCommunity.Models;

namespace PTHCommunity.Controllers
{

    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
      [HttpGet]
        public IEnumerable<string> GetV()
        {
          return new string[] { "Hello", "World" };
        }
    }
}

