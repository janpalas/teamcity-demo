using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Calculator.BL;

namespace Calculator.Web.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IMathematics _mathematics;

        public ValuesController()
        {
            _mathematics = new Mathematics();
        }
        // GET api/values
        public int Get([FromUri]MathematicModel input)
        {
            var ui = new Models.Calculator(_mathematics, input);
            return ui.Calculate();
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
