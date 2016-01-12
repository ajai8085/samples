using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApiTester.Controllers
{
    
    public class ValuesController : ApiController
    {
        private readonly TestFunctions _testFunctions;

        public ValuesController(TestFunctions testFunctions)
        {
            _testFunctions = testFunctions;
        }

        // GET api/values 
        public IEnumerable<string> Get()
        {
            _testFunctions.Test("From values controller ");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5 
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }
    } 
}
