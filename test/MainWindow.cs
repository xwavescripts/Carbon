using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace test
{
    public partial class MainWindow : Form
    {
        ExploitAPI api = new ExploitAPI();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // patched?
            MessageBox.Show("Disabled As Most Scripts Are Patched, Outdated DLL?");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // opening.
            // not outdated! fixed 11/17/22.
            hub ScriptHub = new hub();
            ScriptHub.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string script = richTextBox1.Text;
            api.SendLuaScript(script);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }
    }
}
