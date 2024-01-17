namespace GymMasterFitness
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loginUserName.Text = "";
            loginPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginUserName.Text == "" || loginPassword.Text == "")
            {
                MessageBox.Show("Please input your Username and Password! ");
            }
            else if (loginUserName.Text == "Admin" && loginPassword.Text == "Admin")
            {
                Homepage homepage = new Homepage();
                homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password! ");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}