using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firstapiii.entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Firstapiii.Controllers
{
    [Route("api/firstcontroller")]
    [ApiController]
    public class firstController : ControllerBase
    {
        [Route("first")]
        [HttpGet]
        public string Firstaction(string Name,int Age)
        {
            return $"my name is {Name} and iam {Age} years old";
        }
        [Route("second")]
        [HttpGet]
        public  string Second()
        {
            return "my name thulasi";
        }
        [Route("third")]
        [HttpGet]
        public string AddCat()
        {
            Categorydbcontext categorydbcontext = new Categorydbcontext();
            Category category = new Category();
            category.Categoryname = "vegetarian";
            category.Categorydetails = "pureveg";
            categorydbcontext.Add(category);
            categorydbcontext.SaveChanges();
            return "adddetails";
        }
    }
}
