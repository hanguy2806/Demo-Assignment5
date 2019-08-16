using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * STUDENT NAME: THI THU HA NGUYEN
 * ID:301017727
 * DESCRIPTION: this is splash form.
 */
namespace COMP123_Summer2019.Views
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void ProgressBar_Timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Enabled = false;
            ProgressBar_Timer.Enabled = false;
              Program.startForm.Show();
            this.Hide();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            splashTimer.Enabled = true;
            ProgressBar_Timer.Enabled = true;
          
        }
    }
}
