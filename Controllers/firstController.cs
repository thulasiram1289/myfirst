using Firstapiii.entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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

            category.Categoryname = "nonveg";
            category.Categorydetails = "purenonveg";
            categorydbcontext.Categories.Add(category);
            categorydbcontext.SaveChanges();
            return "adddetails";
        }
        [Route("GeTALLDETAILS")]
        [HttpGet]
        public List<Category> getdetails()
        {
            Categorydbcontext categorydbcontext = new Categorydbcontext();
            return categorydbcontext.Categories.ToList();
        }
        [Route("GeTdetailsbyid")]
        [HttpGet]
        public List<Category> getdetailsbyid(int Id)
        {
            Categorydbcontext categorydbcontext = new Categorydbcontext();
            return categorydbcontext.Categories.Where(i=> i.Id ==Id).ToList();
        }

        [Route("update")]
        [HttpPut]
        public string updatedetails(int Id, Category obj)
        {
            Categorydbcontext categorydbcontext = new Categorydbcontext();
            var ab = categorydbcontext.Categories.Where(i => i.Id == Id).FirstOrDefault();
            ab.Categoryname = obj.Categoryname;
            ab.Categorydetails = obj.Categorydetails;
            categorydbcontext.SaveChanges();
            return "updated";
        }
        [Route("delete")]
        [HttpDelete]
        public string delete(int Id)
        {
            Categorydbcontext categorydbcontext = new Categorydbcontext();
            var ab = categorydbcontext.Categories.Where(i => i.Id == Id).FirstOrDefault();
            categorydbcontext.Categories.Remove(ab);
            categorydbcontext.SaveChanges();
            return "deleted";
        }

























    }
}
