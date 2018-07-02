using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyWqcs
{
    class Clarity
    {
        private TemperatureSensor temperatureSensor;
        private CirculationSensor circulationSensor;
        private LightController lightController;

        public Clarity(TemperatureSensor tempSensor, CirculationSensor circSensor, LightController lightController)
        {
            this.temperatureSensor = tempSensor;
            this.circulationSensor = circSensor;
            this.lightController = lightController;
        }

        public int CalculateClarityLevel()
        {
            return (temperatureSensor.getTemperature() * circulationSensor.GetCirculationLevel()) + lightController.GetLightningDuration();
        }
    }
}
