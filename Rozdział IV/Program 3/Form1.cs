using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = lloyd.Name;
            button2.Text = lucida.Name;
        }

        class Elephant
        {
            public string Name;
            public int EarSize;
            public void WhoAmI()
            {
                MessageBox.Show("Moje uszy mają " + EarSize + " centymetrów szerokości", Name + " mówi ...");
            }
            public void TellMe(string message, Elephant whoSaidIt)
            {
                MessageBox.Show(whoSaidIt.Name + " mówi: " + message);
            }
            public void SpeakTo(Elephant whoToTalkTo, string message)
            {
                whoToTalkTo.TellMe(message, this);
            }
        }

        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        Elephant lucida = new Elephant() { Name = "Lucida", EarSize = 33 };

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucida.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant p = lucida;
            lucida = lloyd;
            lloyd = p;
            button1.Text = lloyd.Name;
            button2.Text = lucida.Name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lucida.SpeakTo(lloyd, "Witaj");
            lloyd.TellMe("Cześć", lucida);
            lloyd = lucida;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }

    }
}
