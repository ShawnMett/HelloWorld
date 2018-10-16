using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hwAPI.Core.Repositories;

namespace hwAPI.Persistance.Repositories
{
    public class HelloWorldRepository : IHelloWorld
    {
       
        // Define DBContext
        public bool SaveMessage(string text)
        {
            //Database call to save data here


            return true;
        }

        public String GetMessage()
        {
            //Database call retrieve saved hello world message


            return "";
        }

    }
}