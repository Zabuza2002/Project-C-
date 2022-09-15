using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_podgotovka
{
    public partial class Form1 : Form
    {
        TradeEntities db = new TradeEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Product.ToList();
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                HomeContent hc = new HomeContent();
                hc.label1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                hc.listBox1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                hc.label2.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                hc.id = dataGridView1.Rows[i].Cells[0].Value.ToString() ;
                //hc.pictureBox1.Image = Image.FromStream(Convert.ToByte(dataGridView1.Rows[i].Cells[4].Value));
                flowLayoutPanel1.Controls.Add(hc);


            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //HomeContent hc = new HomeContent();
            //content.Controls.Add(hc);
            //content.Controls.Add(hc);
        }
        public void showControl(Control control)
        {
            //content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            content.Controls.Add(control);
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
