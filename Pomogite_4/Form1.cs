using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAnipulFromDate;

namespace Pomogite_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            IsDae isDae = new IsDae();

            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsDae isDae = new IsDae();
            MessageBox.Show((isDae.DateWithDae(textBox1.Text,textBox2.Text)).ToString());
            MessageBox.Show(isDae.LeapYear(Convert.ToInt32(textBox3.Text)));
            MessageBox.Show(isDae.TimeOfDay(Convert.ToInt32(textBox4.Text)));
        }
    }
}
