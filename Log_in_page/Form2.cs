namespace Log_in_page
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

                    Form2 form2sec= new Form2();

                    form2sec.Show();
                    this.Hide();
                   

                }


                else
                    label2.Text = "þifre yanlýþ";
            
            
            }



            else { label2.Text = "kullanýcý adý yanlýþ"; }


        }
    }
}