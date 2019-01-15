using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Lift
    {
        private int capasity = 0;
        private int numberFloor = 0;
        private int initaialFloor = 0;
        private int realFloor = 0;

        public Lift()
        {
          
        }
        public void setDateLift(int Lcapasity, int NFloor)
        {
            capasity = Lcapasity;
            numberFloor = NFloor;
        }
        
        public void SetFloor() { }
        

    }
    }
}
