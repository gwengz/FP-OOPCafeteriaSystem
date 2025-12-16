namespace FP_OOPCafeteriaSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignup1_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            
            ExistingAccount loginForm = new ExistingAccount();
            loginForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
