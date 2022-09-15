using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Reflection;
using System.Data.SqlClient;

namespace SmartSoft
{
    public partial class insert_sdelka : Form
    {
        public insert_sdelka()
        {
            InitializeComponent();
        }
        DateTime localDate = DateTime.Now;
        public static main main = new main();

        
        public static Sdelka sdelka = new Sdelka();
        private void insert_sdelka_Load(object sender, EventArgs e)
        {

            
            SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

            con.Open();
            string sql = "select [Наименование_сделки] from [Типы_сделки]";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader rad = com.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(rad);
            dataGridView1.DataSource = table;
            for (int i = 0; i < Convert.ToInt32(dataGridView1.RowCount); i++)
            {
                comboBox1.Items.Add(Convert.ToString(dataGridView1.Rows[i].Cells[0].Value));
            }
            con.Close();


            SqlConnection cons = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

            cons.Open();
            string sqls = "select [Наименование_компании] from [Компании]";
            SqlCommand coms = new SqlCommand(sqls, cons);
            SqlDataReader rads = coms.ExecuteReader();

            DataTable tables = new DataTable();
            tables.Load(rads);
            dataGridView1.DataSource = tables;
            for (int i = 0; i < Convert.ToInt32(dataGridView1.RowCount); i++)
            {
                comboBox3.Items.Add(Convert.ToString(dataGridView1.Rows[i].Cells[0].Value));
            }
            cons.Close();

            SqlConnection conss = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

            conss.Open();
            string sqlss = "select [Наименование_услуги] from [Услуги]";
            SqlCommand comss = new SqlCommand(sqlss, conss);
            SqlDataReader radss = comss.ExecuteReader();

            DataTable tabless = new DataTable();
            tabless.Load(radss);
            dataGridView1.DataSource = tabless;
            for (int i = 0; i < Convert.ToInt32(dataGridView1.RowCount); i++)
            {
                comboBox2.Items.Add(Convert.ToString(dataGridView1.Rows[i].Cells[0].Value));
            }
            conss.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {

                case "Сервер S100":
                   
                    SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

                    con.Open();
                    string sql = "select Стоимость_услуги from услуги where Наименование_услуги = '"+comboBox2.Text+"'";
                    SqlCommand com = new SqlCommand(sql, con);

                    SqlDataReader rad = com.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(rad);

                    dataGridView3.DataSource = table;
                    textBox1.Text = Convert.ToString(Convert.ToInt32(dataGridView3.Rows[0].Cells[0].Value) * Convert.ToInt32(textBox2.Text));
                    dataGridView3.DataSource = "";
                    rad.Close();
                    con.Close();
                    break;
                
                case "Сервер S200":

                    SqlConnection cons = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

                    cons.Open();
                    string sql_1 = "select Стоимость_услуги from услуги where Наименование_услуги = '"+comboBox2.Text+"'";
                    SqlCommand coms = new SqlCommand(sql_1, cons);

                    SqlDataReader rads = coms.ExecuteReader();
                    DataTable tables = new DataTable();
                    tables.Load(rads);

                    dataGridView3.DataSource = tables;
                    textBox1.Text = Convert.ToString(Convert.ToInt32(dataGridView3.Rows[0].Cells[0].Value) * Convert.ToInt32(textBox2.Text));
                    dataGridView3.DataSource = "";
                    rads.Close();
                    cons.Close();
                    break;
                case "Сервер S500":

                    SqlConnection conss = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

                    conss.Open();
                    string sql_2 = "select Стоимость_услуги from услуги where Наименование_услуги = '" + comboBox2.Text + "'";
                    SqlCommand comss = new SqlCommand(sql_2, conss);

                    SqlDataReader radss = comss.ExecuteReader();
                    DataTable tabless = new DataTable();
                    tabless.Load(radss);

                    dataGridView3.DataSource = tabless;
                    textBox1.Text = Convert.ToString(Convert.ToInt32(dataGridView3.Rows[0].Cells[0].Value) * Convert.ToInt32(textBox2.Text));
                    radss.Close();
                    conss.Close();
                    break;

                case "Сервер M1000":

                    SqlConnection consss = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

                    consss.Open();
                    string sql_2s = "select Стоимость_услуги from услуги where Наименование_услуги = '" + comboBox2.Text + "'";
                    SqlCommand comsss = new SqlCommand(sql_2s, consss);

                    SqlDataReader radsss = comsss.ExecuteReader();
                    DataTable tablesss = new DataTable();
                    tablesss.Load(radsss);

                    dataGridView3.DataSource = tablesss;
                    textBox1.Text = Convert.ToString(Convert.ToInt32(dataGridView3.Rows[0].Cells[0].Value) * Convert.ToInt32(textBox2.Text));
                    radsss.Close();
                    consss.Close();
                    break;
                case "Сервер M1000+":

                    SqlConnection conssst = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

                    conssst.Open();
                    string sql_2st = "select Стоимость_услуги from услуги where Наименование_услуги = '" + comboBox2.Text + "'";
                    SqlCommand comssst = new SqlCommand(sql_2st, conssst);

                    SqlDataReader radssst = comssst.ExecuteReader();
                    DataTable tablessst = new DataTable();
                    tablessst.Load(radssst);

                    dataGridView3.DataSource = tablessst;
                    textBox1.Text = Convert.ToString(Convert.ToInt32(dataGridView3.Rows[0].Cells[0].Value) * Convert.ToInt32(textBox2.Text));
                    radssst.Close();
                    conssst.Close();
                    break;
            }

        
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");
            con.Open();
            string sql = "SELECT DISTINCT Типы_сделки.Номер_типа_сделки, Компании.Номер_компании, Услуги.Номер_услуги FROM Типы_сделки, компании, сделка, услуги where Наименование_сделки = '" + comboBox1.Text + "' and Компании.Наименование_компании = '" + comboBox3.Text + "'  and Услуги.Наименование_услуги = '" + comboBox2.Text + "'  ";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader rad = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rad);
            dataGridView2.DataSource = table;
            rad.Close();
            con.Close();


            try
            { 
                
                SqlConnection cons = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");
                cons.Open();
                string sqls = "insert into сделка values('" + dataGridView2.Rows[0].Cells[0].Value + "', '" + textBox1.Text + "', '" + localDate.ToString() + "', '" + dataGridView2.Rows[0].Cells[1].Value + "', '" + dataGridView2.Rows[0].Cells[2].Value + "', '" + textBox2.Text + "');";
                SqlCommand coms = new SqlCommand(sqls, cons);
                SqlDataReader rads = coms.ExecuteReader();
                DataTable tables = new DataTable();
                tables.Load(rads);
                MessageBox.Show("Запись успешно добавлена");
                rads.Close();
                cons.Close();
                textBox1.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";

            }
                catch
                {
                    MessageBox.Show("Ошибка добавления");
                }
            
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            sdelka.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");
                con.Open();
                string sql = "SELECT * from dbo.Компании where Наименование_компании='" + comboBox3.Text + "'";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader rad = com.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(rad);
                dataGridView4.DataSource = table;
                rad.Close();
                con.Close();
                Word.Document doc = null;
                try
                {
                    Word.Application app = new Word.Application();

                    string source = @"C:\Users\takar\OneDrive\Рабочий стол\ДП-4\преддипломная и диплом\Диплом\Акт.docx";

                    doc = app.Documents.Add(source);

                    doc.Activate();

                    Word.Bookmarks wBookmarks = doc.Bookmarks;

                    // wBookmarks["Товары"].Range.Text = DateTime.Now.ToShortDateString();

                    wBookmarks["Лицензиат"].Range.Text = comboBox3.Text.ToString();
                    wBookmarks["ИНН"].Range.Text = dataGridView4.Rows[0].Cells[7].Value.ToString();
                    wBookmarks["Счет"].Range.Text = dataGridView4.Rows[0].Cells[8].Value.ToString();
                    wBookmarks["Email"].Range.Text = dataGridView4.Rows[0].Cells[6].Value.ToString();
                    wBookmarks["Количество"].Range.Text = textBox2.Text.ToString();
                    wBookmarks["Сумма"].Range.Text = textBox1.Text.ToString();
                    wBookmarks["Услуга"].Range.Text = comboBox2.Text.ToString();
                    wBookmarks["Сумма1"].Range.Text = textBox1.Text.ToString();
                    wBookmarks["Сумма2"].Range.Text = textBox1.Text.ToString();
                    wBookmarks["Заказчик"].Range.Text = comboBox3.Text.ToString();
                    wBookmarks["Заказчик2"].Range.Text = comboBox3.Text.ToString();
                    doc.Close();

                }
                catch
                {
                    // Если произошла ошибка, то
                    // закрываем документ и выводим информацию
                    doc.Close();
                    doc = null;
                    Console.WriteLine("Во время выполнения произошла ошибка!");
                    Console.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Не удалось");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Word.Document doc = null;
            try
            {
                Word.Application app = new Word.Application();

                string source = @"C:\Users\takar\OneDrive\Рабочий стол\ДП-4\преддипломная и диплом\Диплом\КП.docx";

                doc = app.Documents.Add(source);

                doc.Activate();

                Word.Bookmarks wBookmarks = doc.Bookmarks;

                // wBookmarks["Товары"].Range.Text = DateTime.Now.ToShortDateString();

                wBookmarks["Товары"].Range.Text = comboBox2.Text.ToString();
                wBookmarks["Цена1"].Range.Text = textBox1.Text.ToString();
             //   wBookmarks["Цена"].Range.Text = textBox1.Text.ToString();
                wBookmarks["Количество"].Range.Text = textBox2.Text.ToString();
                wBookmarks["Сумма"].Range.Text = textBox1.Text.ToString();
                wBookmarks["Сумма1"].Range.Text = textBox1.Text.ToString();
                wBookmarks["Сумма2"].Range.Text = textBox1.Text.ToString();
                doc.Close();

            }
            catch
            {
                // Если произошла ошибка, то
                // закрываем документ и выводим информацию
                doc.Close();
                doc = null;
                Console.WriteLine("Во время выполнения произошла ошибка!");
                Console.ReadLine();
            }
        }
    }
}
