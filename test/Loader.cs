using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace test
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            const string V = "Checking Data...";
            label1.Text = V;
            Thread.Sleep(1000);
            panel2.Size = new Size(496, 35);
            Thread.Sleep(3000);
            const string A = "Checking Typir9 Folders...";
            label1.Text = A;
            panel2.Size = new Size(17, 38);
            Thread.Sleep(2000);
            const string U = "Finished. You May Now Close This Tab.";
            label1.Text = U;
            Form form = new Form();
            form.Hide();
            MainWindow windowUI = new MainWindow();
            windowUI.Show();
        }
    }
}
