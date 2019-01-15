using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel;
using System.Threading;
using Servises;

namespace Model
{
    public class ElevatorManager : InterElevatorManager
    {
        
        private ElevatorServices _lift = new ElevatorServices();
        
        public ElevatorManager() { }
        public void setDateLift(int capasity, int NFloor)
        {
            _lift.Capacity = capasity;
            _lift.NumberFloor = NFloor;
        }
        public int getNumberFloor()
        {
            return _lift.NumberFloor;
        }
        public int getCapacity()
        {
            return _lift.Capacity;
        }
        public void moveUp()
        {
            Thread.Sleep(3000);
            _lift.RealFloor++;
            _lift.InitialFloor = _lift.RealFloor;
        }

        public void moveDown()
        {
            Thread.Sleep(3000);
            _lift.RealFloor--;
            _lift.InitialFloor = _lift.RealFloor;
        }
        public int initFloor()
        {
            return _lift.InitialFloor;
        }
        public int getNowFloorLift()
        {
            return _lift.RealFloor;
        }
        
        public void SetFloor() { }
    }
}
