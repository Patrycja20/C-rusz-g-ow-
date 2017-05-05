using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_4
{
    public partial class Okno : Form
    {
        public Okno()
        {
            InitializeComponent();
        }

        private void changeText_Click(object sender, EventArgs e)
        {
            if (enableCheckbox.Checked == true)
            {
                if (labelToChange.Text == "Z prawej")
                {
                    labelToChange.TextAlign = ContentAlignment.MiddleLeft;
                    labelToChange.Text = "Z lewej";
                }
                else
                {
                    labelToChange.TextAlign = ContentAlignment.MiddleRight;
                    labelToChange.Text = "Z prawej";
                }
            }
            else
            {
                labelToChange.Text = "Możliwość zmiany tekstu została wyłączona";
                labelToChange.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
