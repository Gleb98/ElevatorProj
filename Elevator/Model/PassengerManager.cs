using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel;
using Servises;

namespace Model
{
    public class PassengerManager: InterPassengerManager
    {
      
        private PassengersServices _passenger = new PassengersServices();

        public void setInformation(int idPass, int initialFloor, int finalFloor, int weightpass)
        {
          
            _passenger.Id = idPass;
            _passenger.InitialFloor = initialFloor;
            _passenger.FinalFloor = finalFloor;
            _passenger.Weight = weightpass;

        }
        public bool PositionPassenger
        {
            set { _passenger.Position = value; }
            get { return _passenger.Position; }
        }
        public int idPass
        {
            get { return _passenger.Id;  }
        }
        public bool createPass 
        {
            get { return _passenger.Create; }
        }
        public int inFloorPass
        {
            get { return _passenger.InitialFloor; }
        }
        public int finFloorPass
        {
            get { return _passenger.FinalFloor; }
        }
        public int weigtPass
        {
            get { return _passenger.Weight; }
        }
        public void Delete()
        {
            _passenger.Delete = true;
        }
        public bool getDelete()
        {
            return _passenger.Delete;
        }
        
        

    
    }
}
