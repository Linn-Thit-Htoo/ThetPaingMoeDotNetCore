namespace LoginFormExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            const string adminEmail = "mglinnthithtoo@gmail.com";
            const string adminPassword = "123123";
            string email = txtEmail.Text; // string return
            string password = txtPassword.Text;

            // validation
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields..", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (email == adminEmail && password == adminPassword)
            {
                MessageBox.Show("Login Successful!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Login Fail!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}