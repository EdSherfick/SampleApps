namespace OptimusPrime
{
    partial class PrimeMaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimeRemaingLabel = new System.Windows.Forms.Label();
            this.TimeRemainingValue = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.MaxPrimeNumberValue = new System.Windows.Forms.Label();
            this.MaxPrimeNumberLabel = new System.Windows.Forms.Label();
            this.TimerControl = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimeRemaingLabel
            // 
            this.TimeRemaingLabel.AutoSize = true;
            this.TimeRemaingLabel.Location = new System.Drawing.Point(49, 43);
            this.TimeRemaingLabel.Name = "TimeRemaingLabel";
            this.TimeRemaingLabel.Size = new System.Drawing.Size(230, 32);
            this.TimeRemaingLabel.TabIndex = 0;
            this.TimeRemaingLabel.Text = "Time Remaining:";
            // 
            // TimeRemainingValue
            // 
            this.TimeRemainingValue.Location = new System.Drawing.Point(311, 43);
            this.TimeRemainingValue.Name = "TimeRemainingValue";
            this.TimeRemainingValue.Size = new System.Drawing.Size(353, 32);
            this.TimeRemainingValue.TabIndex = 2;
            this.TimeRemainingValue.Text = " ";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(55, 196);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(609, 92);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MaxPrimeNumberValue
            // 
            this.MaxPrimeNumberValue.Location = new System.Drawing.Point(311, 115);
            this.MaxPrimeNumberValue.Name = "MaxPrimeNumberValue";
            this.MaxPrimeNumberValue.Size = new System.Drawing.Size(353, 32);
            this.MaxPrimeNumberValue.TabIndex = 5;
            this.MaxPrimeNumberValue.Text = " ";
            // 
            // MaxPrimeNumberLabel
            // 
            this.MaxPrimeNumberLabel.AutoSize = true;
            this.MaxPrimeNumberLabel.Location = new System.Drawing.Point(49, 115);
            this.MaxPrimeNumberLabel.Name = "MaxPrimeNumberLabel";
            this.MaxPrimeNumberLabel.Size = new System.Drawing.Size(264, 32);
            this.MaxPrimeNumberLabel.TabIndex = 4;
            this.MaxPrimeNumberLabel.Text = "Max Prime Number:";
            // 
            // TimerControl
            // 
            this.TimerControl.Interval = 1000;
            this.TimerControl.Tick += new System.EventHandler(this.TimerControl_Tick);
            // 
            // PrimeMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 327);
            this.Controls.Add(this.MaxPrimeNumberValue);
            this.Controls.Add(this.MaxPrimeNumberLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TimeRemainingValue);
            this.Controls.Add(this.TimeRemaingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrimeMaker";
            this.Text = "It\'s Prime Time!";
            this.Load += new System.EventHandler(this.PrimeMaker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeRemaingLabel;
        private System.Windows.Forms.Label TimeRemainingValue;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label MaxPrimeNumberValue;
        private System.Windows.Forms.Label MaxPrimeNumberLabel;
        private System.Windows.Forms.Timer TimerControl;
    }
}