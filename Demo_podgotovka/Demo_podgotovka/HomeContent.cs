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
    public partial class HomeContent : UserControl
    {
        TradeEntities db = new TradeEntities();
        public HomeContent()
        {
            InitializeComponent();
        }
        public string id;
        private void button1_Click(object sender, EventArgs e)
        {
            //Add add = new Add();
            //"Insert from table Where Productarticul = id" 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomeContent_Load(object sender, EventArgs e)
        {
            
        }
    }
}
