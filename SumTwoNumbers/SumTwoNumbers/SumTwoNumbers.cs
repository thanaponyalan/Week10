using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumTwoNumbers
{
    public partial class SumTwoNumbers : Form
    {
        public SumTwoNumbers()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            bool isNumeric;
            //get input values and convert strings to doubles
            double number1;
            isNumeric = Double.TryParse(firstNumberTextBox.Text,out number1);
            double number2;
            isNumeric &= Double.TryParse(secondNumberTextBox.Text,out number2);

            if (!isNumeric) return;

            //sum the two numbers
            double sum = number1 + number2;

            //display maximum value
            sumLabel.Text = "Sum : " + sum;
        }
    }
}
