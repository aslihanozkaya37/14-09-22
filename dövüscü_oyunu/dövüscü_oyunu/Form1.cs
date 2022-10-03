using System.Security.Cryptography.X509Certificates;

namespace dövüscü_oyunu
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Oyun oyun = new Oyun();
            oyun.Show();
            
            
           
            if (TankButton1.Checked == true)
            {
                tankBox1.Visible = true;
                uzakBox2.Visible = false;
                assasinsBox3.Visible = false;
                büyücüBox4.Visible = false;

                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
            }
            else if (UzakButton2.Checked == true)
            {
                tankBox1.Visible = false;
                uzakBox2.Visible = true;
                assasinsBox3.Visible = false;
                büyücüBox4.Visible = false;

                groupBox3.Visible = true;
                groupBox2.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
            }
            else if (AssasinsButton3.Checked == true)
            {
                tankBox1.Visible = false;
                uzakBox2.Visible = false;
                assasinsBox3.Visible = true;
                büyücüBox4.Visible = false;

                groupBox4.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox5.Visible = false;
            }
            else
            {
                tankBox1.Visible = false;
                uzakBox2.Visible = false;
                assasinsBox3.Visible = false;
                büyücüBox4.Visible = true;

                groupBox5.Visible = true;
                groupBox4.Visible = false;
                groupBox3.Visible = false;
                groupBox2.Visible = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {



        }
       
       
       
    }
}
