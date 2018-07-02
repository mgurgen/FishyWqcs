using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyWqcs
{
    class Sensor
    {
        private byte data = new byte();

        public void SetData(byte data)
        {
            this.data = data;
        }

        public byte GetData()
        {
            return data;
        }
    }
}
