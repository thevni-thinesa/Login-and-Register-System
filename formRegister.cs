using System.Data.OleDb;

namespace Login_and_Register_System
{
    public partial class formRegister : Form
    {
        public formRegister()
        {
            InitializeComponent();

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_users.mdb");
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblBackLog_Click(object sender, EventArgs e)
        {

        }
    }
}
