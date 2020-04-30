namespace WindowsFormsPartC.Unit5
{
    partial class AnimationForm
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
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.animationPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.horseRadioButton = new System.Windows.Forms.RadioButton();
            this.butterflyRadioButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.animationPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // animationTimer
            // 
            this.animationTimer.Tick += new System.EventHandler(this.UpdateImage);
            // 
            // animationPictureBox
            // 
            this.animationPictureBox.Location = new System.Drawing.Point(325, 174);
            this.animationPictureBox.Name = "animationPictureBox";
            this.animationPictureBox.Size = new System.Drawing.Size(100, 95);
            this.animationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.animationPictureBox.TabIndex = 0;
            this.animationPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.horseRadioButton);
            this.panel1.Controls.Add(this.butterflyRadioButton);
            this.panel1.Location = new System.Drawing.Point(12, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 65);
            this.panel1.TabIndex = 1;
            // 
            // horseRadioButton
            // 
            this.horseRadioButton.AutoSize = true;
            this.horseRadioButton.Location = new System.Drawing.Point(158, 18);
            this.horseRadioButton.Name = "horseRadioButton";
            this.horseRadioButton.Size = new System.Drawing.Size(127, 41);
            this.horseRadioButton.TabIndex = 1;
            this.horseRadioButton.Text = "Horse";
            this.horseRadioButton.UseVisualStyleBackColor = true;
            this.horseRadioButton.CheckedChanged += new System.EventHandler(this.LoadImages);
            // 
            // butterflyRadioButton
            // 
            this.butterflyRadioButton.AutoSize = true;
            this.butterflyRadioButton.Checked = true;
            this.butterflyRadioButton.Location = new System.Drawing.Point(16, 18);
            this.butterflyRadioButton.Name = "butterflyRadioButton";
            this.butterflyRadioButton.Size = new System.Drawing.Size(158, 41);
            this.butterflyRadioButton.TabIndex = 0;
            this.butterflyRadioButton.TabStop = true;
            this.butterflyRadioButton.Text = "Butterfly";
            this.butterflyRadioButton.UseVisualStyleBackColor = true;
            this.butterflyRadioButton.CheckedChanged += new System.EventHandler(this.LoadImages);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(377, 536);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(143, 39);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartAnimation);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(577, 536);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(143, 39);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopAnimation);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(830, 536);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(143, 39);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.CloseForm);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(639, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 37);
            this.lblDate.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(832, 36);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 37);
            this.lblTime.TabIndex = 6;
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.UpdateDateTime);
            // 
            // AnimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(997, 599);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.animationPictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AnimationForm";
            this.Text = "Godfrey\'s Animation Form";
            this.Load += new System.EventHandler(this.LoadImages);
            ((System.ComponentModel.ISupportInitialize)(this.animationPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.PictureBox animationPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton horseRadioButton;
        private System.Windows.Forms.RadioButton butterflyRadioButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer ClockTimer;
    }
}

