using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IModel
{
    public interface InterPassengerManager
    {
        void setInformation(int idPass, int initialFloor, int finalFloor, int weightpass);
        int idPass { get; }
        bool createPass { get; }
        int inFloorPass { get; }
        int finFloorPass { get; }
        int weigtPass { get; }
        void Delete();
        bool getDelete();
        bool PositionPassenger{ set; get; }
    }
}
