using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using hwAPI.Models;

namespace hwAPI.Controllers
{

    
    public class HelloWorldController : ApiController
    {

        //Future enhancement -- Utilze Repository to Get and Save Message Text 
        
        public IList<HelloWorld> hw = new List<HelloWorld>()
        {
            new HelloWorld()
            {
                Id = 1,
                Text = "Hello World!"
            }
        };
       

        public IHttpActionResult Get()
        {
            if (hw == null)
            {
                return NotFound();
            }
            return Ok(hw);
        }

    }
}
