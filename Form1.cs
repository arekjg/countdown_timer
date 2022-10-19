using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace countdown_timer
{
    public partial class CountDownTimer : Form
    {
        public CountDownTimer()
        {
            InitializeComponent();
        }

        int timeleft = 60;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                TimerLabel.Text = timeleft + " seconds";
            }
            else
            {
                timer.Stop();
                TimerLabel.Text = "Time is up!";
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timeleft = 60;
            TimerLabel.Text = timeleft + " seconds";
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            timeleft = timeleft + 5;
            TimerLabel.Text = timeleft + " seconds";
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            timeleft = timeleft - 5;
            TimerLabel.Text = timeleft + " seconds";
        }
    }
}