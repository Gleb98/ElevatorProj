using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWiew;

namespace lift
{
    public partial class FinalFrame : Form, InterFinalFrame
    {
        public FinalFrame()
        {
            InitializeComponent();
        }

        public void setNumberTrip(int numTrip)
        {
            labelNumberTrip.Text += " " + numTrip.ToString();
        }
        public void setFreeTrip(int numTrip)
        {
            labelFreeTrip.Text +=  " " + numTrip.ToString();
        }
        public void setSumWeight(int weight)
        {
            labelSumWeight.Text += " " + weight.ToString();
        }
        public void setNumberPassenger(int numPass)
        {
            LabelNumberPassenger.Text += " " + numPass.ToString();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FinalFrame_Load(object sender, EventArgs e)
        {

        }
    }
}
