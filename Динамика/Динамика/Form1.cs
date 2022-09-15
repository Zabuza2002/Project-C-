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

namespace Динамика
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source = KYPAMA\KYPAMA; Initial Catalog = ДокументацияОСЗН; Integrated Security = SSPI;");

            con.Open();

            SqlCommand com = new SqlCommand("Select * from [Граждане]", con);
            DataTable table = new DataTable();
            SqlDataReader reader = com.ExecuteReader();
            table.Load(reader);
            
            con.Close();
            max = table.Rows.Count;
            count = max / 6;
            if (max % 6 != 0)
            {
                count++;
            }
            for (int i = 1; i <= count; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Height = 40;
                button.Width = 40;
                button.Click += new EventHandler(this.Click1);
                flowLayoutPanel2.Controls.Add(button);
            }
            button2.Click += new EventHandler(this.Click1);
            button3.Click += new EventHandler(this.Click1);
            //int nach = 
            for (int n = 0; n <= 5; n++)
            {
                Объект control = new Объект();
                string stroka = table.Rows[n].ItemArray[1].ToString() + table.Rows[n].ItemArray[2].ToString() + table.Rows[n].ItemArray[3].ToString();
                control.label1.Text = stroka;
                flowLayoutPanel1.Controls.Add(control);
            }
        }
        SqlConnection con;
        int max;
        int count;
      
        
        int a = 1;
        private void Click1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string b = sender.ToString().Replace("System.Windows.Forms.Button, Text: ","");
            if (b != "<" && b != ">")
            {
                a = Convert.ToInt32(b);
            }
            
            
            int nach = (a-1)*6;
            

            con.Open();

            SqlCommand com = new SqlCommand("Select * from [Граждане]", con);
            DataTable table = new DataTable();
            SqlDataReader reader = com.ExecuteReader();
            table.Load(reader);

            con.Close();
            max = table.Rows.Count;
            int koneth;
            if (max - nach > 6)
            {
                koneth = nach + 5;
            }
            else
            {
                koneth = max-1;
            }
            for (int n = nach; n <= koneth; n++)
            {
                Объект control = new Объект();
                string stroka = table.Rows[n].ItemArray[2].ToString() + table.Rows[n].ItemArray[3].ToString() + table.Rows[n].ItemArray[4].ToString();
                control.label1.Text = stroka;
                //control.pictureBox1.Image = Convert.table.Rows[n].ItemArray[5];
                flowLayoutPanel1.Controls.Add(control);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a > 1)
            {
                a -= 1;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (a < count)
            {
                a += 1;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
