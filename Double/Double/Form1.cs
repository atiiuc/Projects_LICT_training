using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleOfNumberApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowDouble_Click(object sender, EventArgs e)
        {
            int num,num1;
          
            num = Convert.ToInt32(inputNum.Text);
            num1=GetDouble(num);
            outputNum.Text = num1.ToString();

        }
        public int GetDouble(int inputNumber)
        {
            inputNumber = inputNumber * 2;
            return inputNumber;
        }
    }
}
