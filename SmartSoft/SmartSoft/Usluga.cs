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
    public partial class Usluga : Form
    {
        public Usluga()
        {
            InitializeComponent();
        }

        private void Usluga_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");
            con.Open();
            string sql = "select Номер_услуги as 'Номер', наименование_услуги as 'Услуга', Стоимость_услуги As 'Цена'  from услуги ";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader rad = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rad);
            dataGridView1.DataSource = table;
            con.Close();
        }
        public static Primary primary = new Primary();
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            primary.Show();
        }
        Unsert_Usluga inst_usl = new Unsert_Usluga();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            inst_usl.Show();
        }
        public static Update_Usluga update_usluga = new Update_Usluga();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_usluga.Show();
        }
        public static Delete_Usluga del_usl = new Delete_Usluga();
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            del_usl.Show();
        }
    }
}
