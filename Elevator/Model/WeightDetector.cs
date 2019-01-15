using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel;

namespace Model
{
   
    public class WeightDetector
    {
        private List<PassengerManager> _pass;
        private ElevatorManager _lift;
        

        public WeightDetector(List<PassengerManager> pass, ElevatorManager lift)
        {
            _pass = pass;
            _lift = lift;
        }
        public bool OverloadPass(int id)
        {
            int SummWeight = 0;
            SummWeight = _pass[id].weigtPass;
            for(int i = 0; i < _pass.Count; i++)
            {
                if(_pass[i].PositionPassenger == true && _pass[i].getDelete() == false)
                {
                    SummWeight += _pass[i].weigtPass;
                }
            }

            if (SummWeight <= _lift.getCapacity()) return false;
            else return true;
        }

        public int SummaryMoveWeight()
        {
            int SummWeight = 0;
            for (int i = 0; i < _pass.Count; i++)
            {
                
                SummWeight = SummWeight + _pass[i].weigtPass;
             
            }
            return SummWeight;

        }

        
    }
}
