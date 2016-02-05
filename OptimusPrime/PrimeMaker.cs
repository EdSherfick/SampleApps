using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimusPrime
{
    public partial class PrimeMaker : Form
    {
        // set time remaining
        const int DURATION_IN_SECONDS = 60;
        int _timeRemaining;
        SimplePrimeController _controller = new SimplePrimeController();

        // Declare a System.Threading.CancellationTokenSource.
        CancellationTokenSource _cts;

        public PrimeMaker()
        {
            InitializeComponent();

            _controller.PrimeNumberFound += OnPrimeNumberFound;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartTimerCountDown();
            TimeRemainingValue.Text = GetTimeRemainingText(_timeRemaining);

            try
            {
                _cts = new CancellationTokenSource();
                _controller.Cts = _cts;
                //Asynchronously Call PrimerController to Generate Numbers
                Task primeNumberGenerationTask = new Task(new Action(GeneratePrimeNumbers));
                primeNumberGenerationTask.Start();

            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Gerenator Canceled");
            }
            catch (Exception)
            {
                MessageBox.Show("Gernate Failed");
            }

            StartButton.Enabled = false;
        }

        private void GeneratePrimeNumbers()
        {
            _controller.Generate();
        }

        private void PrimeMaker_Load(object sender, EventArgs e)
        {

        }

        private void TimerControl_Tick(object sender, EventArgs e)
        {
            _timeRemaining--;
            if (_timeRemaining > 0)
            {
                TimeRemainingValue.Text = GetTimeRemainingText(_timeRemaining);
            }
            else
            {
                _cts.Cancel();
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
                text = string.Format(CultureInfo.InvariantCulture, "{0:#,0} Seconds", timeRemaining);
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

        public void OnPrimeNumberFound(object sender, PrimeNumberFoundEventArgs e)
        {
            // Because this is raised by a separate thread, we have to invoke an action to avoid cross thread exception.
            if (MaxPrimeNumberValue.InvokeRequired)
            {
                MaxPrimeNumberValue.Invoke(new Action<long>(SetMaxPrimeNumber), e.PrimeNumber);
                return;
            }
        }

        public void SetMaxPrimeNumber(long primeNumber)
        {
            MaxPrimeNumberValue.Text = string.Format(CultureInfo.InvariantCulture, "{0:#,0}", primeNumber);
        }
    }
}
