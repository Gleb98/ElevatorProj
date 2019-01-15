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
    
    public partial class MainFrame : Form, InterMainFrame
    {
        private int _id = 1;
        public event EventHandler<EventArgs> ButtonAdd;
        public event EventHandler<EventArgs> ButtonStart;
        public event EventHandler<EventArgs> ButtonView;
        public event EventHandler<EventArgs> ButtonOK;
        public event EventHandler<EventArgs> ButtonStop;
        public FinalFrame _fFrame;
      
        public MainFrame(FinalFrame fFrame)
        {
            InitializeComponent();
            _fFrame = fFrame;
            
        }
        public string getInitialFloor() {  return tBoxInFloor.Text; }
        public string getFinishFloor() { return tBoxFFlor.Text; }
        public string getWeight() { return tBoxWeight.Text; }
        public int getID() { return _id; }
        public string getNumberFloor() { return tBoxNumberFloor.Text; }  
        public string getCapasity()  { return tBoxCapacity.Text; }
        public void ErrorPassenger(int numberTextBox) 
        {
            if (numberTextBox == 1) tBoxInFloor.BackColor = Color.GreenYellow;
            if (numberTextBox == 2) tBoxFFlor.BackColor = Color.GreenYellow;
            if (numberTextBox == 3) tBoxWeight.BackColor = Color.GreenYellow;
        }
        public void ErrorLift(int numberTextBox)
        {
            if (numberTextBox == 1) tBoxNumberFloor.BackColor = Color.OrangeRed;
            if (numberTextBox == 2) tBoxCapacity.BackColor = Color.OrangeRed;
        }
        public void CorrectlyPassenger(int numberTextBox)
        {
            if (numberTextBox == 1) tBoxInFloor.BackColor = Color.White; ;
            if (numberTextBox == 2) tBoxFFlor.BackColor = Color.White; ;
            if (numberTextBox == 3) tBoxWeight.BackColor = Color.White; ;
        }
        public void CorrectlyLift()
        {
            tBoxNumberFloor.BackColor = Color.White;
            tBoxCapacity.BackColor = Color.White;
            bOk.Enabled = false;
            bAdd.Enabled = true;
            bStart.Enabled = true;
        }
        public void newPassenger()
        {
            _id++;
            tBoxInFloor.Text = "0";
            tBoxFFlor.Text = "0";
            tBoxWeight.Text = "0";
            LabelNumPass.Text = _id.ToString();
        }

        
        private void bAdd_Click(object sender, EventArgs e)
        {
            if (ButtonAdd != null)
            {
                ButtonAdd(this, EventArgs.Empty);
            }

        }
        
     
        private void bStart_Click(object sender, EventArgs e)
        {
            if (ButtonStart != null)
            {
                ButtonStart(this, EventArgs.Empty);
            }
            bStart.Enabled = false;
            bStop.Enabled = true;
        }

        
        private void bWiew_Click(object sender, EventArgs e)
        {
            if (ButtonView != null)
            {
                ButtonView(this, EventArgs.Empty);
            }
            _fFrame.Show();
            bView.Enabled = false;
      
        }

       
        private void bOk_Click(object sender, EventArgs e)   
        {
            if (ButtonOK != null)
            {
                ButtonOK(this, EventArgs.Empty);
            }
            
        }

      
        private void bStop_Click(object sender, EventArgs e)
        {
            if (ButtonStop != null)
            {
                ButtonStop(this, EventArgs.Empty);
            }
            bStop.Enabled = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void labelLift_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
