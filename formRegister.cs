using System.Data.OleDb;

namespace Login_and_Register_System
{
    public partial class formRegister : Form
    {
        public formRegister()
        {
            InitializeComponent();

        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtpassword.Text == "" && txtconfirmpass.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Faild..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtpassword.Text == txtconfirmpass.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + txtUsername.Text + "', '" + txtpassword.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtpassword.Text = "";
                txtconfirmpass.Text = "";

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtconfirmpass.Text = "";
                txtpassword.Focus();
            }
        }

        private void checkbxshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxshowpass.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtconfirmpass.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '.';
                txtconfirmpass.PasswordChar = '.';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtconfirmpass.Text = "";
            txtUsername.Focus();
        }

        private void lblBackLog_Click(object sender, EventArgs e)
        {
            new loginForm().Show();
            this.Hide();
        }














        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
