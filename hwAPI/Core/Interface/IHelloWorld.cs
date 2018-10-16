using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hwAPI.Core.Repositories
{
    public interface IHelloWorld
    {
        String GetMessage();
        bool SaveMessage(string text);
        
    }
}