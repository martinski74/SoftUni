using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumator
{
    public partial class Калкулатор : Form
    {
        public Калкулатор()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Калкулатор_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = decimal.Parse(this.textBox1.Text);
                var num2 = decimal.Parse(this.textBox2.Text);
                var sum = num1 + num2;
                this.textBox3.Text = "" + sum;
            }
            catch (Exception)
            {

                textBox3.Text = "error";
            }
           
        }
    }
}
