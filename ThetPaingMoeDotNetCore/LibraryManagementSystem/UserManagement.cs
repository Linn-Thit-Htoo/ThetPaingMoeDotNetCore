using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class UserManagement : Form
    {
        public string connectionString = "Data Source=(local);Initial Catalog=ThetPaingMoe;Integrated Security=True";
        public UserManagement()
        {
            InitializeComponent();
        }

        private void UserManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new(connectionString);
                connection.Open();

                string query = @"SELECT UserId, UserName, Email, Password, UserRole, CreateDate, IsDeleted FROM [User]
WHERE IsDeleted = @IsDeleted";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@IsDeleted", false);
                command.CommandType = CommandType.Text; // default
                SqlDataAdapter adapter = new(command);
                DataTable dt = new();
                adapter.Fill(dt);

                dgv1.DataSource = dt;

                // Add a new column
                DataGridViewButtonColumn editButtonColumn = new();
                editButtonColumn.Text = "Edit";
                editButtonColumn.UseColumnTextForButtonValue = true;
                dgv1.Columns.Add(editButtonColumn);

                // Add a new column
                DataGridViewButtonColumn deleteButton = new();
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                deleteButton.DefaultCellStyle.BackColor = Color.Red;
                dgv1.Columns.Add(deleteButton);

                connection.Close();
            }
            catch
            {
                throw;
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.ColumnIndex.ToString());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateNewUserForm createNewUserForm = new();
            createNewUserForm.Show();
            this.Hide();
        }
    }
}
