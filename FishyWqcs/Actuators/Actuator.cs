using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyWqcs
{
    public class Actuator
    {
        private byte data;

        public void SetData(byte data)
        {
            this.data = data;
        }

        virtual public void SetActuatorData()
        {
            //Manipulate data here with switch light field.
            data = new byte();
            SetData(data);
        }
    }
}
