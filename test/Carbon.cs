using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Carbon : Form
    {
        public Carbon()
        {
            InitializeComponent();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Carbon_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Carbon_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Carbon_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Information.DiscordInvite();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            TopMost = true;
            label3.Text = "TOPMOST: ON";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TopMost = false;
            label3.Text = "TOPMOST: OFF";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loader loader = new Loader();
            loader.Show();
            Carbon carbon = new Carbon();
            carbon.Hide();
        }
    }
}