using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toolbox_24_UI.Scripts.Windows_Activator;

namespace Toolbox_24_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            new WinActUI().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start(@".\Restart Explorer\RstExpl.ps1");
        }
    }
}
