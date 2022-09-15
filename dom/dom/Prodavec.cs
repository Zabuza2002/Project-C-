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
using System.IO;

namespace dom
{
    public partial class Prodavec1 : Form
    {
        public Prodavec1()
        {
            InitializeComponent();
        }
        
        private void Prodavec1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog = Prokat; Integrated Security = SSPI;");
            con.Open();

            SqlCommand com = new SqlCommand("Select ФИО, Должность, Image from Сотрудники where Код_сотрудника ='"+name.ID+"'", con);
            DataTable table = new DataTable();
            SqlDataReader reader = com.ExecuteReader();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
            label1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            label2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            byte[] bytes=(byte[])dataGridView1.Rows[0].Cells[2].Value;
            MemoryStream ms = new MemoryStream(bytes);
            pictureBox1.Image = Image.FromStream(ms);

            SqlConnection cons = new SqlConnection(@"Data Source = DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog = Prokat; Integrated Security = SSPI;");
            cons.Open();

            SqlCommand coms = new SqlCommand("Select ФИО, Должность, Image from Сотрудники where Код_сотрудника ='" + name.ID + "'", cons);
            DataTable tables = new DataTable();
            SqlDataReader readers = coms.ExecuteReader();
            tables.Load(readers);
            dataGridView1.DataSource = tables;
            cons.Close();
        }
    }
}
