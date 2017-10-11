using Rocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
   public static class RocketExt
    {
        public static void ChangeDestination(this Pslv rocket,string changedDestination)
        {
            rocket.Destination = changedDestination;
        }
    }
}
