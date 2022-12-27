using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user = textBox1.Text.ToString();
            string pass=textBox2.Text.ToString();

            if (user == "admin") 
            {


                if (pass == "admin")
                {
                    Form1 form1sec = new Form1();
                    form1sec.Show();
                    this.Hide();

                }

                else
                    label2.Text = "şifre yanlış";
                


            }

            else
                label2.Text = "kullanıcı adı yanlış";




        }
    }
}
