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
        // set time remaining
        const int DURATION_IN_SECONDS = 60;
        int _timeRemaining;

        public PrimeMaker()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartTimerCountDown();
            TimeRemainingValue.Text = GetTimeRemainingText(_timeRemaining);

            //TODO:  Asynchronously Call PrimerController to Generate Numbers

            StartButton.Enabled = false;
        }

        private void PrimeMaker_Load(object sender, EventArgs e)
        {

        }

        private void TimerControl_Tick(object sender, EventArgs e)
        {
            if (_timeRemaining > 0)
            {
                _timeRemaining--;
                TimeRemainingValue.Text = GetTimeRemainingText(_timeRemaining);
            }
            else
            {
                TimeRemainingValue.Text = GetTimeRemainingText(_timeRemaining);
                StopTimerCountDown();
            }            
        }

        private string GetTimeRemainingText(int timeRemaining)
        {
            string text = string.Empty;

            if (timeRemaining < 1)
            {
                text = "Times Up!";
            }
            else if (timeRemaining == 1)
            {
                text = "1 Second";
            }
            else
            {
                text = string.Format("{0} Seconds", timeRemaining.ToString());
            }

            return text;
        }

        private void StartTimerCountDown()
        {
            _timeRemaining = DURATION_IN_SECONDS;
            TimerControl.Start();
            Cursor.Current = Cursors.WaitCursor;
        }

        private void StopTimerCountDown()
        {
            TimerControl.Stop();
            StartButton.Enabled = true;
            Cursor.Current = Cursors.Default;
            _timeRemaining = DURATION_IN_SECONDS;
        }
    }
}
