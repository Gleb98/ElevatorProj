using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWiew;
using IModel;

namespace Presentation
{
    public class InfoPressenter
    {
        private InterRealTimeFrame rtFrame;
        private InterElevatorSystem liftSystem;
        public InfoPressenter (InterRealTimeFrame rt_Frame, InterElevatorSystem lift_System)
        {
            rtFrame = rt_Frame;
            liftSystem = lift_System;
            liftSystem.information += InformationPassenger;
            liftSystem.status += CallLift;
            liftSystem.statusLift += LiftMove;
            liftSystem.LiftStop += liftStop;
        
        }

        private void InformationPassenger(object sender, EventArgs e)
        {
            rtFrame.addInfPassenger(liftSystem.getInfomationPassenger());
            rtFrame.addNumberFloor(liftSystem.getLiftInformation());
            rtFrame.addNumberPassenger(liftSystem.getNumberPassenger());
        }
        private void CallLift(object sender, EventArgs e)
        {
            rtFrame.addStatusPassenger(liftSystem.getInformationCallLift());
        }
        private void LiftMove(object sender, EventArgs e)
        {
            rtFrame.addMoveLift(liftSystem.getNowLift());
        }
        private void liftStop(object sender, EventArgs e)
        {
            rtFrame.addStopLift();
        }

    }
}
