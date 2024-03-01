using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class CreateNewUserForm : Form
    {
        public string connectionString = "Data Source=(local);Initial Catalog=ThetPaingMoe;Integrated Security=True";
        public CreateNewUserForm()
        {
            InitializeComponent();
        }

        private void CreateNewUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                string userRole = cbo1.Text;
                DateTime dateTime = DateTime.Now;

                if (IsNull(userName) || IsNull(email) || IsNull(password) || IsNull(userRole))
                {
                    MessageBox.Show("Please fill all fields...", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (IsEmailDuplicate(email))
                {
                    MessageBox.Show("User with this email already exists!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConnection connection = new(connectionString);
                connection.Open();

                string query = @"INSERT INTO [dbo].[User]
           ([UserName]
           ,[Email]
           ,[Password]
           ,[UserRole]
           ,[CreateDate]
           ,[IsDeleted])
     VALUES (@UserName, @Email, @Password, @UserRole, @CreateDate, @IsDeleted)";

                SqlCommand cmd = new(query, connection);
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@UserRole", userRole);
                cmd.Parameters.AddWithValue("@CreateDate", dateTime);
                cmd.Parameters.AddWithValue("@IsDeleted", false);

                int result = cmd.ExecuteNonQuery();
                connection.Close();

                if (result > 0)
                {
                    txtUserName.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    cbo1.Text = string.Empty;

                    MessageBox.Show("User created.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show("Creating user fail.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                throw;
            }
        }

        private bool IsNull(string str)
        {
            return string.IsNullOrEmpty(str);
        }

        private bool IsEmailDuplicate(string email)
        {
            try
            {
                SqlConnection connection = new(connectionString);
                connection.Open();

                string query = @"SELECT UserId, UserName, Email, Password, UserRole, CreateDate, IsDeleted FROM [User]
WHERE Email = @Email";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                SqlDataAdapter adapter = new(command);
                DataTable dt = new();
                adapter.Fill(dt);
                connection.Close();

                return dt.Rows.Count > 0;
            }
            catch
            {
                throw;
            }
        }
    }
}
