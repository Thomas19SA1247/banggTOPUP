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


namespace TopUp
{
    public partial class transaksi_form : Form
    {
        menu_form f1;
        public transaksi_form(menu_form form1)
        {
            InitializeComponent();
            this.f1 = form1;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void transaksi_form_Load(object sender, EventArgs e)
        {
            NamaGameTB.SelectedItem = f1.comboBox1.SelectedItem;
            IdGameTB.Text = f1.textBox1.Text;
        }

        private void NamaGameTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NamaGameTB.SelectedItem.ToString() == "ARENA OF VALOR")
            {
                comboBox1.SelectedIndex = -1;
                comboBox1.Items.Clear();
                comboBox1.Items.Add("100 VOC");
                comboBox1.Items.Add("300 VOC");
                comboBox1.Items.Add("500 VOC");
                comboBox1.Items.Add("1000 VOC");
            }
            else if (NamaGameTB.SelectedItem.ToString() == "MOBILE LEGEND")
            {
                comboBox1.SelectedIndex = -1;
                comboBox1.Items.Clear();
                comboBox1.Items.Add("100 DM");
                comboBox1.Items.Add("300 DM");
                comboBox1.Items.Add("500 DM");
                comboBox1.Items.Add("1000 DM");
            }
            else if (NamaGameTB.SelectedItem.ToString() == "FREE FIRE")
            {
                comboBox1.SelectedIndex = -1;
                comboBox1.Items.Clear();
                comboBox1.Items.Add("100 DM");
                comboBox1.Items.Add("300 DM");
                comboBox1.Items.Add("500 DM");
                comboBox1.Items.Add("1000 DM");
            }
            else if (NamaGameTB.SelectedItem.ToString() == "PUBG")
            {
                comboBox1.SelectedIndex = -1;
                comboBox1.Items.Clear();
                comboBox1.Items.Add("100 UC");
                comboBox1.Items.Add("300 UC");
                comboBox1.Items.Add("500 UC");
                comboBox1.Items.Add("1000 UC");
            }
        }
        private void BACK_Click(object sender, EventArgs e)
        {
            menu_form objmenu_form = new menu_form();
            this.Hide();
            objmenu_form.Show();

        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AOV
            if (comboBox1.SelectedItem.ToString() == "100 VOC")
            {

                textBox5.Text = "53000";
            }
            else if (comboBox1.SelectedItem.ToString() == "300 VOC")
            {

                textBox5.Text = "103000";
            }
            else if (comboBox1.SelectedItem.ToString() == "500 VOC")
            {

                textBox5.Text = "153000";
            }
            else if (comboBox1.SelectedItem.ToString() == "1000 VOC")
            {

                textBox5.Text = "203000";
            }



            //ML

            else if (comboBox1.SelectedItem.ToString() == "100 DM")
            {

                textBox5.Text = "50000";
            }
            else if (comboBox1.SelectedItem.ToString() == "300 DM")
            {

                textBox5.Text = "100000";
            }
            else if (comboBox1.SelectedItem.ToString() == "500 DM")
            {

                textBox5.Text = "150000";
            }
            else if (comboBox1.SelectedItem.ToString() == "1000 DM")
            {

                textBox5.Text = "200000";
            }

            //PUBG
            else if (comboBox1.SelectedItem.ToString() == "100 UC")
            {

                textBox5.Text = "56000";
            }
            else if (comboBox1.SelectedItem.ToString() == "300 UC")
            {

                textBox5.Text = "106000";
            }
            else if (comboBox1.SelectedItem.ToString() == "500 UC")
            {

                textBox5.Text = "156000";
            }
            else if (comboBox1.SelectedItem.ToString() == "1000 UC")
            {

                textBox5.Text = "205000";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox3.Text = "10";
            }

            if (radioButton2.Checked)
            {
                textBox3.Text = "15";
            }
            textBox6.Text = (Convert.ToDouble(textBox5.Text) - Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox3.Text) / 100).ToString();

            textBox7.Text = "";
            Random random = new Random();
            int length = 8;
            for (int i = 0; i < length; i++)
            {
                if (random.Next(0, 3) == 0) //if random.Next() == 0 then we generate a random character
                {

                    textBox7.Text += ((char)random.Next(65, 91)).ToString();
                }
                else //if random.Next() == 0 then we generate a random digit
                {

                    textBox7.Text += random.Next(0, 9);
                }


            }



        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }


        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\TopUpApp\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void GetValue()
        {

            DataTable dt = new DataTable();

            sqlcon.Open();
            string qry = "select * from TableTrans";
            SqlCommand cmd = new SqlCommand(qry, sqlcon);
            SqlDataReader rdr = cmd.ExecuteReader();
            dt.Load(rdr);
            sqlcon.Close();
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu_form objmenu_form = new menu_form();
            this.Hide();
            objmenu_form.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonshow_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\TopUpApp\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO TableTrans(NamaGame,IdGame,Nominal,TotalHarga,KodePembayaran) VALUES('" + NamaGameTB.SelectedItem + "', @IdGame,@Nominal,@TotalHarga,@KodePembayaran)", sqlcon);
                cmd.Parameters.AddWithValue("@IdGame", IdGameTB.Text);
                cmd.Parameters.AddWithValue("@Nominal", comboBox1.Text);
                cmd.Parameters.AddWithValue("@TotalHarga", textBox6.Text);
                cmd.Parameters.AddWithValue("@KodePembayaran", textBox7.Text);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                GetValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
