using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Globalization;
using System.IO;

namespace login
{
    public partial class Home : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=AWA-PC\SQLEXPRESS;Initial Catalog=db_lks;Integrated Security=True");
        public Home()
        {
            InitializeComponent();
            display_data();
        }

        string type;
        string imgLocation = "";
        SqlCommand cmd;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM [husbus] where id = '" + textBox6.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            textBox6.Text = "";
            MessageBox.Show("Data has been deleted!");
            display_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            images = brs.ReadBytes((int)streem.Length);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO [husbus] (name,made_from,type,description,image) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + type + "','" + textBox3.Text + "',@images)";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            pictureBox1.ImageLocation = null;
            conn.Close();
            MessageBox.Show("Your data has been created!");
            display_data();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = "Anime";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type = "Game";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            type = "Comic";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void display_data()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT name,made_from,description FROM [husbus]";
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            dta.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void showData()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [husbus] where id='" + textBox5.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader.GetString(1);
                textBox2.Text = reader.GetString(2);
                textBox3.Text = reader.GetString(3);
                /*MemoryStream ms = new MemoryStream((byte[])reader[5]);
                pictureBox1.Image = Image.FromStream(ms);
                */
                button8.Visible = true;
                if (reader.GetString(4) == "Anime")
                {
                    radioButton1.Checked = true;
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                }
                else if (reader.GetString(4) == "Game")
                {
                    radioButton2.Checked = true;
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                }
                else if (reader.GetString(4) == "Comic")
                {
                    radioButton3.Checked = true;
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Data not found!");
                button8.Visible = false;
                pictureBox1.Image = null;
                clear();
            }
            conn.Close();

        }
        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;

            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;

            pictureBox1.ImageLocation = null;
            pictureBox1.Image = null;
            button8.Visible = false;
            button2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
            display_data();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(streem);
            images = br.ReadBytes((int)br.BaseStream.Length);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE [husbus] SET name = '" + this.textBox1.Text + "',made_from = '" + this.textBox2.Text + "',description = '" + this.textBox3.Text + "',type = '" + type + "',image = @images where id = '" + this.textBox5.Text + "'";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            conn.Close();
            clear();
            MessageBox.Show("Data has been updated!");
            display_data();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [husbus] where id ='" + textBox7.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader.GetString(1);
                textBox2.Text = reader.GetString(2);
                textBox3.Text = reader.GetString(3);
                MemoryStream ms = new MemoryStream((byte[])reader[5]);
                pictureBox1.Image = Image.FromStream(ms);
                button2.Visible = false;

                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;

                if (reader.GetString(4) == "Anime")
                {
                    radioButton1.Checked = true;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                }
                else if (reader.GetString(4) == "Game")
                {
                    radioButton2.Checked = true;
                    radioButton1.Enabled = false;
                    radioButton3.Enabled = false;
                }
                else if (reader.GetString(4) == "Comic")
                {
                    radioButton3.Checked = true;
                    radioButton2.Enabled = false;
                    radioButton1.Enabled = false;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                    radioButton1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Data not found!");
                button8.Visible = false;
                pictureBox1.Image = null;
                clear();
            }
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string keyword = textBox4.Text;
            cmd.CommandText = $"SELECT * FROM [husbus] WHERE name LIKE '%{keyword}%' OR description LIKE '%{keyword}%' OR made_from LIKE '%{keyword}%' OR type LIKE '%{keyword}%'";
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            dta.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            textBox7.Text = "";
        }
    }
}
