using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;
using Model;

namespace lift
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FinalFrame FFrame = new FinalFrame();
            MainFrame mFrame = new MainFrame(FFrame);
            RealTimeFrame RTFrame = new RealTimeFrame();            
            ElevatorSystem Lsys = new ElevatorSystem();


            CreatePresenter sysLift = new CreatePresenter(mFrame, Lsys);
            InfoPressenter infLift = new InfoPressenter(RTFrame, Lsys);
            FinalInfoPresenter finalInf = new FinalInfoPresenter(FFrame, Lsys);
                       
                        
            RTFrame.Show();
            Application.Run(mFrame);
            
           
        }
    }
}
