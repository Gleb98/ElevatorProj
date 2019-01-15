using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWiew
{
    public interface InterMainFrame
    {
        string getInitialFloor();
        string getFinishFloor();
        string getWeight();
        int getID();
        string getNumberFloor();
        string getCapasity();
        void ErrorPassenger(int numberTextBox);
        void ErrorLift(int numberTextBox);
        void CorrectlyPassenger(int numberTextBox);
        void CorrectlyLift();
        void newPassenger();
        


        event EventHandler<EventArgs> ButtonAdd;
        event EventHandler<EventArgs> ButtonOK;
        event EventHandler<EventArgs> ButtonStart;
        event EventHandler<EventArgs> ButtonStop;
        event EventHandler<EventArgs> ButtonView;



    }
}

