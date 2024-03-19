using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class CreateUserForm : Form
    {
        public string _connectionString = "Data Source=(local);Initial Catalog=ThetPaingMoe;Integrated Security=True;User ID=saPassword=sa@123;";
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void CreateUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text;
                string email = txtEmail.Text;

                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please fill all fields...", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConnection conn = new SqlConnection(_connectionString);
                conn.Open();
                string query = @"INSERT INTO [User] (UserName, Email, UserRole, CreateDate, IsDeleted)
VALUES (@UserName, @Email, @UserRole, @CreateDate, @IsDeleted)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@UserRole", "user");
                cmd.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@IsDeleted", 0);
                int result = cmd.ExecuteNonQuery();
                conn.Close();

                if (result > 0)
                {
                    txtUserName.Text = "";
                    txtEmail.Text = "";
                    DialogResult dialog = MessageBox.Show("Creating Successful.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                    return;
                }
                MessageBox.Show("Creating Fail.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                throw;
            }
        }
    }
}
