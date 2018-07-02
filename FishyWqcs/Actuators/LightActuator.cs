using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyWqcs
{
    class LightActuator : Actuator
    {
        private bool switchLight;

        public void SwitchLight(bool switchLight)
        {
            this.switchLight = switchLight;
            SetActuatorData();
        }
    }
}
