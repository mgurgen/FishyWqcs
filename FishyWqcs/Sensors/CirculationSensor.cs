using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyWqcs
{
    class CirculationSensor : Sensor
    {
        private int circulationLevel;

        public int GetCirculationLevel()
        {
            return circulationLevel;
        }

        public void SetCirculationLevel()
        {
            //extract circulation level data from raw data here
            this.circulationLevel = GetData();
        }
    }
}
