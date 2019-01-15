using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWiew
{
    public interface InterRealTimeFrame
    {
        void addInfPassenger(string information);
        void addNumberPassenger(int num);
        void addNumberFloor(int numfloor);
        void addStatusPassenger(string information);
        void addMoveLift(int num);
        void addStopLift();

        
    }
}
