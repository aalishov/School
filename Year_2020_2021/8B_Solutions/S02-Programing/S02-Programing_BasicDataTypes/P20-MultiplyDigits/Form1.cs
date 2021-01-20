using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P20_MultiplyDigits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            string inputNumber = inputTextBox.Text;
            int number = int.Parse(inputNumber);
            int firstDigit = number / 10;
            int lastDigit = number % 10;
            int result = firstDigit * lastDigit;    
            resultLabel.Text = result.ToString();
        }
    }
}
