using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyWqcs
{
    class Program
    {
        static void Main(string[] args)
        {
            LightActuator lightActuator = new LightActuator();
            LightController lightController = new LightController(lightActuator);

            lightController.setLightActuator(true);
        }
    }
}
