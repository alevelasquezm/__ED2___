using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab_02_.Controllers;
using Newtonsoft.Json;
using Lab_02_.Models;
namespace Lab_02_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        // GET api/values

        public Btree tree = new Btree();
        public Path path = new Path();
        public  BSearch search= new BSearch();



        
        [HttpGet]
        public string Get()
        {
            var content = "Ingresar" + path.inOrder();
            return content;
        }
        // GET api/values/5
        [Route("SearchItem")]
        [HttpGet]
        public string Get([FromBody] string brandNew)
        {
            string found;
            var searchedItem = search.Search(brandNew);
            
            if (searchedItem != null)
            {
                found =  "Name: " + searchedItem.Name + "\n" + "Flavor: " + searchedItem.Flavor + "\n" + "Volume: " + searchedItem.Volume + "\n" + "Price: " + searchedItem.Price+ "Producer House: " + searchedItem.Producer_House;

            }
            else
            {
                found = "ERROR, NOT FOUND";
            }
            return found;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Soda item)
        {
            tree.insert(item);
        }

      /*  // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
