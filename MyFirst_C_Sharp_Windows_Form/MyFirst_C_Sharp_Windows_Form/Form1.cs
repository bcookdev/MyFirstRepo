using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirst_C_Sharp_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Great you are happy!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Snap! It looks like you are sad!");
        }
    }
}
