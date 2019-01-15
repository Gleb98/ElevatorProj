using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IModel
{
    public interface InterElevatorManager
    {
        void setDateLift(int Lcapasity, int NFloor);
        int getNumberFloor();
        void moveUp();
        int initFloor();
        int getNowFloorLift();
        void SetFloor();
        void moveDown();
        int getCapacity();
    }
    
}
