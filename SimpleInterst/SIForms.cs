using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterst
{
    public partial class SIForms : Form
    {
        public SIForms()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 == null || textBox2 == null || textBox3 == null)
            {
                MessageBox.Show("Please enter the Values");
            }
            else
            {
                decimal Principal = Convert.ToDecimal(textBox1.Text);
                decimal interest = Convert.ToDecimal(textBox2.Text);
                decimal interstPeried = Principal * (interest / 100);
                decimal TotlPI = Principal + interstPeried;
                textBox3.Text = TotlPI.ToString();
                MessageBox.Show((TotlPI).ToString());
            }
        }
    }
}
