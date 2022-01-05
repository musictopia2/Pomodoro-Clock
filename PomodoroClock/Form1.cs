﻿using System;
using System.Windows.Forms;
using System.Timers;

namespace PomodoroClock
{
    public partial class PomodoClock : Form
    {
        public PomodoClock()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private System.Timers.Timer interval;
        private int[] lengths = {25, 5};

        // Session length
        // Increase button
        private void sessionInc_Click(object sender, EventArgs e)
        {
            if (lengths[0] < 60)
            {
                lengths[0] = lengths[0] + 1;
            }

            if (lengths[0] < 10)
            {
                sessionLength.Text = $"0{lengths[0]}";
            } else
            {
                sessionLength.Text = lengths[0].ToString();
            }

            if (timeLabel.Text == "Session")
            {
                timer.Text = $"{lengths[0]}:00";
            }
        }

        // Decrease button
        private void sessionDec_Click(object sender, EventArgs e)
        {
            if (lengths[0] > 1)
            {
                lengths[0] = lengths[0] - 1;
            }

            if (lengths[0] < 10)
            {
                sessionLength.Text = $"0{lengths[0]}";
            }
            else
            {
                sessionLength.Text = lengths[0].ToString();
            }

            if (timeLabel.Text == "Session")
            {
                timer.Text = $"{lengths[0]}:00";
            }
        }

        // Break Length
        // Increase button
        private void breakInc_Click(object sender, EventArgs e)
        {
            if (lengths[1] < 60)
            {
                lengths[1] = lengths[1] + 1;
            }

            if (lengths[1] < 10)
            {
                breakLength.Text = $"0{lengths[1]}";
            }
            else
            {
                breakLength.Text = lengths[1].ToString();
            }

            if (timeLabel.Text == "Break")
            {
                timer.Text = $"{lengths[1]}:00";
            }
        }

        // Decrease button
        private void breakDec_Click(object sender, EventArgs e)
        {
            if (lengths[1] > 1)
            {
                lengths[1] = lengths[1] - 1;
            }

            if (lengths[1] < 10)
            {
                breakLength.Text = $"0{lengths[1]}";
            }
            else
            {
                breakLength.Text = lengths[1].ToString();
            }

            if (timeLabel.Text == "Break")
            {
                timer.Text = $"{lengths[1]}:00";
            }
        }

        // Start/Pause button
        private void btn_sot_Click(object sender, EventArgs e)
        {
            if (interval == null)
            {
                interval = new System.Timers.Timer(1000);
                interval.AutoReset = true;
            }
        }

        // Reset button
        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (interval != null)
            {
                interval = null;
            }
            lengths[0] = 25;
            lengths[1] = 5;
            sessionLength.Text = lengths[0].ToString();
            breakLength.Text = $"0{lengths[1]}";
            timeLabel.Text = "Session";
            timer.Text = $"{lengths[0]}:00";
        }
    }
}