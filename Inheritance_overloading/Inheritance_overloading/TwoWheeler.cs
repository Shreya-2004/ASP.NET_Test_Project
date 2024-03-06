using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_overloading
{
    public class TwoWheeler
    {

        public string TwoWheelerSpeed;
        public string TwoWheelerColor;
        public string DisplaySpeed()
        {
            return TwoWheelerSpeed;
        }
        public string SetSpeed(string speed)
        {
            TwoWheelerSpeed = speed;
            return TwoWheelerSpeed;
        }
    }

}
