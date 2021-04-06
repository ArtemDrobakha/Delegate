using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button4.Click += new EventHandler(this.buttonMy_Click);
        }
        bool colir = true;
        bool prozorist = true;
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("World Home. World заблокований з міркувань карантину");
        }
        private void buttonMy_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                prozorist = !prozorist;
                if (prozorist == false)
                {
                    this.Opacity = 0.5;
                }
                else
                {
                    this.Opacity = 1;
                }
            }
            if (checkBox2.Checked == true)
            {
                colir = !colir;
                if (colir == false)
                {
                    this.BackColor = Color.Yellow;
                }
                else
                {
                    this.BackColor = Color.LightGray;
                }
            }
            if (checkBox3.Checked == true)
            {
                MessageBox.Show("World Home. World заблокований з міркувань карантину");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            colir = !colir;
            if (colir == false)
            {
                this.BackColor = Color.Yellow;
            }
            else {
                this.BackColor = Color.LightGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prozorist = !prozorist;
            if (prozorist == false)
            {
                this.Opacity = 0.5;
            }
            else
            {
                this.Opacity = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі мене цього не позбавиш");
        }
    }
}
