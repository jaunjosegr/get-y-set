using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace get_y_set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Clasemul OO = new Clasemul();
            OO.N1 = (int.Parse(textBox1.Text));
            OO.N2 = (int.Parse(textBox2.Text));
            textBox3.Text = OO.mul().ToString();
        }
    }
}
