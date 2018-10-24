using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseEngine.Services;

namespace BaseEngine
{
    //this will keep a list of all the services like rendering and audio or physics ai etc
    public class ServiceManager
    {
        public List<Service> services = new List<Service>();

        public Service GetService()
        {
            throw new NotImplementedException();
        }
    }
}
