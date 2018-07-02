namespace FishyWqcs
{
    class LightController
    {
        private LightActuator lightActuator;
        private int lightningDuration;

        public LightController(LightActuator lightActuator)
        {
            this.lightActuator = lightActuator;
        }

        public void setLightActuator(bool onOrOff)
        {
            this.lightActuator.SwitchLight(onOrOff);
        }

        public int GetLightningDuration()
        {
            return this.lightningDuration;
        }
    }
}
