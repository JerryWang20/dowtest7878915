using dow.dowtest7878915.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dow.dowtest7878915.Service.Controllers
{
    public class ExceptionController : ApiController
    {
        // POST api/<controller>
        public void Post([FromBody]string value)
        {
            try
            {
                ClientLogger.WriteError(value);
            }
            catch
            {
                // If it fail to log, not throw out new exception.
            }
            
        }
    }
}