using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CorePracticeApplication.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public IProductManager _productManager;
        public ValuesController(IProductManager productManager)
        {
            _productManager = productManager;
        }
       
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var result = _productManager.GetProduct();
            return result.Select(x => x.Name).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
