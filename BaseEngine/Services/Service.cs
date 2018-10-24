using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseEngine.Components;

namespace BaseEngine.Services
{
    public abstract class Service
    {
        public abstract void AddComponent(Component component);
    }
}
