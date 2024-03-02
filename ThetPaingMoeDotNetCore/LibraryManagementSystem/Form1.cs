using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public string connectionString = "Data Source=(local);Initial Catalog=ThetPaingMoe;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DateTime today = DateTime.Now;
            //string date = today.ToString("yyyy-MM-dd hh:m:ss");
            //MessageBox.Show(date);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill all fields...", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlConnection connection = new(connectionString);
                connection.Open();

                string query = @"SELECT UserId, UserName, Email, Password, UserRole, CreateDate, IsDeleted FROM [User]
WHERE Email = @Email AND Password = @Password AND IsDeleted = @IsDeleted AND UserRole = @UserRole"; // to avoid injection

                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@IsDeleted", false);
                command.Parameters.AddWithValue("@UserRole", "admin");

                SqlDataAdapter adapter = new(command);
                DataTable dt = new();
                adapter.Fill(dt); // dt = adapter.Fill();

                if (dt.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Login Successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        UserManagementForm userManagement = new();
                        userManagement.Show();
                        this.Hide();
                        return;
                    }
                }
                MessageBox.Show("Login Fail!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                connection.Close();
            }
            catch
            {
                throw;
            }
        }
    }
}