using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWiew;
using IModel;

namespace Presentation
{
   public class CreatePresenter
    {
        private InterMainFrame mFrame;
        private InterElevatorSystem liftSystem;
       
        public CreatePresenter(InterMainFrame m_Frame, InterElevatorSystem lift_System)
        {
            mFrame = m_Frame;
            liftSystem = lift_System;
            mFrame.ButtonAdd += GetInfPassenger;
            mFrame.ButtonOK += GetLiftInformation;
            mFrame.ButtonStart += MoveLift;
            mFrame.ButtonStop += StopThreadLift;
            mFrame.ButtonView += OpenFForm;
        }

        private void GetInfPassenger(object sender, EventArgs e)
        {
            decimal d; 
            for(int i = 1; i <= 3; i++)
            {
                mFrame.CorrectlyPassenger(i);
            }

            if (!decimal.TryParse(mFrame.getInitialFloor(), out d) ||
                Convert.ToInt32(mFrame.getInitialFloor()) <= 0 ||
                Convert.ToInt32(mFrame.getInitialFloor()) > liftSystem.getLiftInformation())
            {
                mFrame.ErrorPassenger(1);
            }
            else if (!decimal.TryParse(mFrame.getFinishFloor(), out d) ||
                Convert.ToInt32(mFrame.getFinishFloor()) <= 0 ||
                Convert.ToInt32(mFrame.getFinishFloor()) > liftSystem.getLiftInformation())
            {
                mFrame.ErrorPassenger(2);
            }
            else if (!decimal.TryParse(mFrame.getWeight(), out d) ||
                Convert.ToInt32(mFrame.getWeight()) <= 0)
            {
                mFrame.ErrorPassenger(3);
            }
            else
            {
                liftSystem.addInformationPassenger
                    (mFrame.getID(), Convert.ToInt32(mFrame.getInitialFloor()), 
                    Convert.ToInt32(mFrame.getFinishFloor()), Convert.ToInt32(mFrame.getWeight()));

                for (int i = 1; i <= 3; i++)
                {
                    mFrame.CorrectlyPassenger(i);
                }

                mFrame.newPassenger();

            }

        }
        private void GetLiftInformation(object sender, EventArgs e) 
        {
            decimal d;
            if (!decimal.TryParse(mFrame.getNumberFloor(), out d) ||
                Convert.ToInt32(mFrame.getNumberFloor()) <= 0)
            {
                mFrame.ErrorLift(1);
            }
            else if (!decimal.TryParse(mFrame.getCapasity(), out d) ||
                Convert.ToInt32(mFrame.getCapasity()) <= 0)
            {
                mFrame.ErrorLift(2);
            }
            else
            {
                liftSystem.addInformationLift(Convert.ToInt32(mFrame.getNumberFloor()), Convert.ToInt32(mFrame.getCapasity()));

                mFrame.CorrectlyLift();
            }
        }

        private void StopThreadLift(object sender, EventArgs e)
        {
            liftSystem.StopThread();
        }
        private void MoveLift(object sender, EventArgs e)
        {
            liftSystem.Start();
            
        }
        private void OpenFForm(object sender, EventArgs e)
        {
            liftSystem.SetFinalInfotmation();
        }

       
    }
}
