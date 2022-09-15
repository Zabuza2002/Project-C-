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
    public partial class Primary : Form
    {
        public Primary()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       public static Sdelka sdelka = new Sdelka();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            sdelka.Show();
        }
        public static company comp = new company();
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            comp.Show();
        }
        public static Usluga usluga = new Usluga();
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            usluga.Show();
        }
    }
}
