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


namespace TopUp
{
    public partial class menu_form : Form
    {
        public menu_form()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Regex mRegxExpression;



            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("Please entery your data.");
                
            }




            else
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\TopUpApp\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO PlayerTable(NamaGame,IdGame,Nickname,Email) VALUES('" + comboBox1.SelectedItem + "', @IdGame,@Nickname,@Email)", sqlcon);
                cmd.Parameters.AddWithValue("@IdGame", textBox1.Text);
                cmd.Parameters.AddWithValue("@Nickname", textBox2.Text);
                cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Confirmed");

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("Please entery your data.");

            }
            else
            {

                transaksi_form objtransaksi_form = new transaksi_form(this);
                this.Hide();
                objtransaksi_form.ShowDialog();
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty || textBoxEmail.Text != string.Empty)
                comboBox1.SelectedIndex = -1;
            textBox1.Text = "";
            textBox2.Text = "";
            textBoxEmail.Text = "";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
