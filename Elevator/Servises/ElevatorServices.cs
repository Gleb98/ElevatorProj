using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servises
{
    public class ElevatorServices
    {
        private int _capasity = 0;
        private int _numberFloor = 0;
        private int _initialFloor = 1;
        private int _realFloor = 1;
        public ElevatorServices() { }

        public int Capacity
        {
            get { return _capasity; }
            set { _capasity = value; }
        }
        public int NumberFloor
        {
            get { return _numberFloor; }
            set { _numberFloor = value; }
        }
        public int InitialFloor
        {
            get { return _initialFloor; }
            set { _initialFloor = value; }
        }
        public int RealFloor
        {
            get { return _realFloor; }
            set { _realFloor = value; }
        }
    }
}
