using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IModel
{
    
    public interface InterElevatorSystem
    {
        void addInformationLift(int numFloor, int capacity);
        void addInformationPassenger(int id, int initialFloor, int finishFloor, int weight);
        string getInfomationPassenger();
        string getInformationCallLift();
        int getLiftInformation();
        int getNumberPassenger();
        int getNowLift();
        void Start();
        void StopThread();
        void SetFinalInfotmation();
        int getSummWeight();
        int getSumPass();
        int GetNumberTrip();
        int getFreeTrip();

        event EventHandler<EventArgs> information;
        event EventHandler<EventArgs> status;
        event EventHandler<EventArgs> statusLift;
        event EventHandler<EventArgs> LiftStop;
        event EventHandler<EventArgs> finalInformation;


    }
}
