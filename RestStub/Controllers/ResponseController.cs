using RestStub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestStub.Controllers
{
    public class ResponseController : ApiController
    {
        // GET: api/Response
        public IEnumerable<ResponseInfo> Get()
        {
            var newb = new List<ResponseInfo>();
            for (int i = 0; i < 5; ++i)
            {
                var responseInfo = new ResponseInfo
                {
                    Data = $"Some data: {i} \n"
                };
                newb.Add(responseInfo);
            }
            return newb;

        }

        // GET: api/Response/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Response
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Response/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Response/5
        public void Delete(int id)
        {
        }
    }
}
