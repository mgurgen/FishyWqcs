using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyWqcs
{
    class TemperatureSensor : Sensor
    {
        private int temperature;

        public void SetData()
        {
            //extract temperature data from raw data here
            this.temperature = GetData();
        }

        public int getTemperature()
        {
            return temperature;
        }
    }
}
