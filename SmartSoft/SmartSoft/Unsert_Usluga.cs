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

namespace SmartSoft
{
    public partial class Unsert_Usluga : Form
    {
        public Unsert_Usluga()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cons = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");
                cons.Open();
                string sqls = "insert into Услуги values('" + textBox1.Text + "', '" + textBox2.Text + "')";
                SqlCommand coms = new SqlCommand(sqls, cons);
                SqlDataReader rads = coms.ExecuteReader();
                DataTable tables = new DataTable();
                tables.Load(rads);
                MessageBox.Show("Услуга '" + textBox1.Text + "' успешно добавлена!");
                rads.Close();
                cons.Close();
                textBox1.Text = "";
                textBox2.Text = "";
             

            }
            catch
            {
                MessageBox.Show("Ошибка добавления услуги, повторите попытку!");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public static Usluga usluga = new Usluga();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            usluga.Show();
        }
    }
}
