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


        }

        private void button2_Click(object sender, EventArgs e)
        {

                transaksi_form objtransaksi_form = new transaksi_form(this);
                this.Hide();
                objtransaksi_form.ShowDialog();
            
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
   
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            
            BN 
        }
   
    }
}
