using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Masuk_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=AWA-PC\SQLEXPRESS;Initial Catalog=db_lks;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from users where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            // kalo bener
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Home call = new Home();
                call.Show();
            }
            // kalo salah
            else
            {
                MessageBox.Show("Invalid username or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}