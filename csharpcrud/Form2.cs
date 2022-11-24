using System.Data;
using System.Data.SqlClient;

namespace CrudDeneme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=DESKTOP-MTU4EKB;Database=NORTHWND;User Id=sa;Password=1234;");
        
        private void Form2_Load(object sender, EventArgs e)
        {

            SqlDataAdapter adp = new SqlDataAdapter("Select * FROM Products", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;
        }

    

        public void Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * FROM Products", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;
        }


        private void button1_Click(object sender, EventArgs e)
         {
        
            string name = textBox2.Text;
            decimal price = numericUpDown1.Value;
            if(name==""|| price==null)
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurunuz.");
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"insert into Products (ProductName, UnitPrice) values('{name}',{price})";
            con.Open();
            cmd.ExecuteNonQuery();
            Listele();
            con.Close();
        }

       
    }
}