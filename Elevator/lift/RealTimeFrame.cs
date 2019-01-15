using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using IWiew;

namespace lift
{
    public partial class RealTimeFrame : Form, InterRealTimeFrame
    {
        delegate void SetTextCallback(string information);
        delegate void SetNumCallback(int num);
        delegate void SetNumCallback_2();

        public RealTimeFrame()
        {
            InitializeComponent();
           
            textBoxStatus.Text = "";             
            textBoxInfPassenger.Text = "";
            
            
        }

        public void addStatusPassenger(string information)
        {
            if (this.textBoxStatus.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(addStatusPassenger);
                this.Invoke(d, new object[] { information });

            }
            else
            {
                textBoxStatus.Text = information;
            }
        }
        public void addMoveLift(int num)
        {
            if (this.textBoxStatus.InvokeRequired)
            {
                SetNumCallback d = new SetNumCallback(addMoveLift);
                this.Invoke(d, new object[] { num });

            }
            else
            {
                labelStatusLift.Text = "Elevator condition: move";
                

            }
        }
        public void addInfPassenger(string information)
        {
          
            textBoxInfPassenger.Text = information;
        }
        public void addNumberPassenger(int num)
        {

       
            labelNPasseger.Text = num.ToString();

            
        }
        public void addNumberFloor(int numfloor)
        {
            

        }
        
        public void addStopLift()
        {
            if (this.textBoxStatus.InvokeRequired)
            {
                SetNumCallback_2 d = new SetNumCallback_2(addStopLift);
                this.Invoke(d, new object[] {});

            }
            else
            {
                labelStatusLift.Text = "Elevator condition: stop";
                
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Start_lift_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void labelNPasseger_Click(object sender, EventArgs e)
        {

        }

        private void MLift_Scroll(object sender, EventArgs e)
        {

        }
    }
}
