namespace ExampleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnGreeting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome User!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}