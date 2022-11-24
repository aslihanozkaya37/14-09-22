using System.Data;
using System.Data.SqlClient;

namespace CSharpAdo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-MTU4EKB;Database=NORTHWND;User Id=sa;Password=1234;");
            //con.Open();
            //label1.Text = con.State.ToString();
            //con.Close();



            SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM Products", con);
            DataTable dt=new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource=dt;
            //veri cekme -zor yöntem

            SqlCommand cmd = new SqlCommand("SELECT * FROM Categories",con);
            con.Open();
            SqlDataReader reader= cmd.ExecuteReader();
            while(reader.Read())
            {
                string name = reader["CategoryName"].ToString();
                string desc = reader["Description"].ToString();
                listBox1.Items.Add($"{name}-{desc}");


            }
            con.Close();


        }
    }
}