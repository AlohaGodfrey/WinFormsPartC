using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPartC.Unit5
{
    /// <summary>
    /// This form shows an animation of a helicopter which will fly across
    /// and down the screen.
    /// </summary>
    public partial class FlyMeForm : Form
    {
        public const int MAXN_HORIZONTAL_SPEED = 100;
        private Animation animation = new Animation(4);
        private int horizontalSpeed = 10;
        private int VerticalSpeed = 20;
        public const string BACKGROUND1 = "City1.wmf";
        public const string BACKGROUND2 = "City2.wmf";
        public const string BACKGROUND_BASE = "../../Images/Town and Sky/";

        private string background = BACKGROUND1;

        public FlyMeForm()
        {
            InitializeComponent();
            speedScrollbar.Value = horizontalSpeed;
        }

        private void quitForm(object sender, EventArgs e)
        {
            Close();
        }

        private void startStopAnimation(object sender, EventArgs e)
        {
            if(stopRadioButton.Checked)
            {
                animationTimer.Enabled = false;
            }
            else
            {
                animationTimer.Enabled = true;
            }
        }

        private void updateCopter(object sender, EventArgs e)
        {
            copterPictureBox.Image = animation.GetNextImage();
            copterPictureBox.Left += horizontalSpeed;

            Bitmap bitmap = new Bitmap(BACKGROUND_BASE+background);
            this.BackgroundImage = bitmap;

            if (copterPictureBox.Left > Width)
            {
                copterPictureBox.Left = -copterPictureBox.Width;
                copterPictureBox.Top += VerticalSpeed;

                if(background == BACKGROUND2)
                {
                    background = BACKGROUND1;
                }
                else
                {
                    background = BACKGROUND2;
                }
                
            }
        }

        private void loadImages(object sender, EventArgs e)
        {
            string baseFileName = "../../Images/Copter/copter";
            animation.LoadImages(baseFileName);
        }

        private void UpdateSpeed(object sender, ScrollEventArgs e)
        {
            horizontalSpeed = speedScrollbar.Value;
        }
    }
}
