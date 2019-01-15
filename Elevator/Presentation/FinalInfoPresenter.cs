using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWiew;
using IModel;

namespace Presentation
{
    public class FinalInfoPresenter
    {
        private InterFinalFrame _fFrame;
        private InterElevatorSystem _lSystem;
        public FinalInfoPresenter(InterFinalFrame fFrame, InterElevatorSystem lSystem)
        {
            _fFrame = fFrame;
            _lSystem = lSystem;
            _lSystem.finalInformation += AddFinalInformation;
        }

        private void AddFinalInformation(object sender, EventArgs e)
        {
            _fFrame.setSumWeight(_lSystem.getSummWeight());
            _fFrame.setNumberPassenger(_lSystem.getNumberPassenger());
            _fFrame.setNumberTrip(_lSystem.GetNumberTrip());
            _fFrame.setFreeTrip(_lSystem.getFreeTrip());
        }
    }
}
