using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorld.WebAPI.Controllers
{
    public class SayHelloWorldAPIController : ApiController
    {
       
        // GET: api/SayHelloWorldAPI
        public string Get()
        {
            return "Hello World";
        }

       
    }
}
