using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int MyMethod(bool yesNo)
        {
            if (yesNo) return 45;
            else return 61;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal myDecimalValue = 10;
            int myIntValue = (int)myDecimalValue;
            
            MessageBox.Show("myIntValue jest równe: " + myIntValue);

            int mylnt = 10;
            byte myByte = (byte)mylnt;
            double myDouble = (double)myByte;
            string myString = "false";
            short myShort = (short)mylnt;
            long myLong = (long)mylnt;
            decimal myDecimal = (decimal)myLong;
        }
    }
}
