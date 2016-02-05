using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimusPrime
{
    public partial class PrimeMaker : Form
    {
        int timeRemaining;

        public PrimeMaker()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO");
            //TODO:  Set Time Remaining
            //TODO:  Start Timer 
            //TODO:  Asynchronously Call PrimerController to Generate Numbers
        }

        private void PrimeMaker_Load(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            //TODO:  Decrement Time Remaining
            //TODO:  When time runs out, stop asych prime number generation
            //TODO:  Display MaxPrimeNumber
        }
    }
}
