using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public string _connectionString = "Data Source=(local);Initial Catalog=ThetPaingMoe;Integrated Security=True;User ID=saPassword=sa@123;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(_connectionString);
                conn.Open();
                string query = "SELECT * FROM [User]";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
