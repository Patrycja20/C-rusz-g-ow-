using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " ma " + joe.Cash + " zł";
            bobsCashLabel.Text = bob.Name + " ma " + bob.Cash + " zł";
            bankCashLabel.Text = "Bank ma " + bank + " zł";

        }

        public Form1()
        {
            InitializeComponent();
            
            joe = new Guy(){ Name = "Joe", Cash = 50};
            //joe.Name = "Joe";
            //joe.Cash = 50;

            bob = new Guy() { Name = "Bob", Cash = 100 };
            //bob.Name = "Bob";
            //bob.Cash = 100;

            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
                MessageBox.Show("Bank nie posiada takiej ilości pieniędzy");
            }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            
            UpdateForm();
        }

        private void bobGivesToBob_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));

            UpdateForm();
        }
    }
}
