using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class EditUserForm : Form
    {
        public int _userID;
        public string _userName, _email, _password, _userRole;

        public string _connectionString = "Data Source=(local);Initial Catalog=ThetPaingMoe;Integrated Security=True";
        public EditUserForm(int userID, string userName, string email, string password, string userRole)
        {
            InitializeComponent();
            _userID = userID;
            _userName = userName;
            _email = email;
            _password = password;
            _userRole = userRole;
        }

        private void EditUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagement = new();
            userManagement.Show();
            this.Hide();
        }

        private void cbo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            txtUserName.Text = _userName;
            txtEmail.Text = _email;
            txtPassword.Text = _password;
            cbo1.Text = _userRole;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string userRole = cbo1.Text;

            if (Validation.IsNullOrEmpty(userName, email, password, userRole))
            {
                MessageBox.Show("Please fill all fields...", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsEmailDuplicate(_userID, email))
            {
                MessageBox.Show("User with this email already exists!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection connection = new(_connectionString);
            connection.Open();

            string query = @"UPDATE [User] SET UserName = @UserName, Email = @Email, Password = @Password, UserRole = @UserRole
WHERE UserId = @UserId AND IsDeleted = @IsDeleted";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@UserRole", userRole);
            command.Parameters.AddWithValue("@IsDeleted", false);
            command.Parameters.AddWithValue("@UserId", _userID);

            int result = command.ExecuteNonQuery();
            connection.Close();

            if (result > 0)
            {
                MessageBox.Show("User updated.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserManagementForm userManagementForm = new();
                userManagementForm.Show();
                this.Hide();
                return;
            }

            MessageBox.Show("Updating user fail.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool IsEmailDuplicate(int id, string email)
        {
            try
            {
                SqlConnection connection = new(_connectionString);
                connection.Open();

                string query = @"SELECT UserId, UserName, Email, Password, UserRole, CreateDate, IsDeleted FROM [User]
WHERE Email = @Email AND UserId != @UserId AND IsDeleted = @IsDeleted";

                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@UserId", id);
                command.Parameters.AddWithValue("@IsDeleted", false);

                SqlDataAdapter adapter = new(command);
                DataTable dt = new();
                adapter.Fill(dt);
                connection.Close();

                return dt.Rows.Count > 0; // if duplicate email exists, return true
            }
            catch
            {
                throw;
            }
        }
    }
}
