using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;

namespace chechbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Dorucak_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked && checkBox6.Checked)
            {
                textBox1.Text = "Netočno";
            }
            else if (checkBox6.Checked && checkBox7.Checked)
            {
                textBox1.Text = "Netočno";
            }
            else if (checkBox5.Checked && checkBox7.Checked)
            {
               
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                textBox1.Visible = false;
            }
            else
            {
               textBox1.Visible = true;
            }
        }
    }
}
