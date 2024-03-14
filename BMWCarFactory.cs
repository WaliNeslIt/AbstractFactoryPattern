using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BMWCarFactory : IRoadVehicleFactory
    {
        public IEngine processEngine()
        {
            return new BMWCarEngine();
        }

        public ITyres processTyre()
        {
            return new BMWBikeTyre();
        }
    }
}
