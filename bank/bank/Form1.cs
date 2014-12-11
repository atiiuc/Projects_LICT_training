using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankInterestCalculateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int interest=0,result,amount,year;

            int.TryParse(textBox1.Text, out amount);
            int.TryParse(textBox2.Text, out year);
            if (comboBox1.Text == "Brac")
            {
                interest=5;
            }
            if (comboBox1.Text == "DBBL")
            {
                interest=6;
            }
            if (comboBox1.Text == "HSBC")
            {
                interest=7;
            }
            result = (interest * amount * year) / 100;
             textBox3.Text =Convert.ToString(result);
           
        }
       
    }
}
