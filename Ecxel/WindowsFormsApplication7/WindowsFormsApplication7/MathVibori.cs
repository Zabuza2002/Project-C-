using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication7
{
    public partial class MathVibori : Form
    {

        List<string> FirstMesto = new List<string>();
        List<string> SecondMesto = new List<string>();
        List<string> ThirdMesto = new List<string>();
        List<string> FourthMesto = new List<string>();

        string[] potentialwinners = new string[4] { "A", "B", "C", "D" };

        public string server;
        string dir = new FileInfo(@"server.txt").FullName;

        List<string> Golosa = new List<string>();

        public MathVibori()
        {
            InitializeComponent();
            Golosa.Add(golos1.Text); Golosa.Add(golos2.Text); Golosa.Add(golos3.Text); Golosa.Add(golos4.Text); Golosa.Add(golos5.Text); Golosa.Add(golos6.Text); Golosa.Add(golos7.Text); Golosa.Add(golos8.Text); Golosa.Add(golos9.Text); Golosa.Add(golos10.Text); Golosa.Add(golos11.Text);
            FirstMesto.Add(one1.Text); FirstMesto.Add(one2.Text); FirstMesto.Add(one3.Text); FirstMesto.Add(one4.Text); FirstMesto.Add(one5.Text); FirstMesto.Add(one6.Text); FirstMesto.Add(one7.Text); FirstMesto.Add(one8.Text); FirstMesto.Add(one9.Text); FirstMesto.Add(one10.Text); FirstMesto.Add(one11.Text);
            SecondMesto.Add(two1.Text); SecondMesto.Add(two2.Text); SecondMesto.Add(two3.Text); SecondMesto.Add(two4.Text); SecondMesto.Add(two5.Text); SecondMesto.Add(two6.Text); SecondMesto.Add(two7.Text); SecondMesto.Add(two8.Text); SecondMesto.Add(two9.Text); SecondMesto.Add(two10.Text); SecondMesto.Add(two11.Text);
            ThirdMesto.Add(three1.Text); ThirdMesto.Add(three2.Text); ThirdMesto.Add(three3.Text); ThirdMesto.Add(three4.Text); ThirdMesto.Add(three5.Text); ThirdMesto.Add(three6.Text); ThirdMesto.Add(three7.Text); ThirdMesto.Add(three8.Text); ThirdMesto.Add(three9.Text); ThirdMesto.Add(three10.Text); ThirdMesto.Add(three11.Text);
            FourthMesto.Add(four1.Text); FourthMesto.Add(four2.Text); FourthMesto.Add(four3.Text); FourthMesto.Add(four4.Text); FourthMesto.Add(four5.Text); FourthMesto.Add(four6.Text); FourthMesto.Add(four7.Text); FourthMesto.Add(four8.Text); FourthMesto.Add(four9.Text); FourthMesto.Add(four10.Text); FourthMesto.Add(four11.Text);

            StreamReader sr = new StreamReader(dir);
            server = sr.ReadLine();

            //dataGridView1.Columns.Add("Предпочтения", "Предпочтения");
            //dataGridView1.Columns.Add("Голоса", "Голоса");
         
            for (int i = 0; i < 110; i++)
            {
              //  dataGridView1.Rows.Add();
            }
            for (int i = 0; i < 11; i++)
            {
             //   dataGridView1.Rows[i].Cells[0].Value = "Олег";              
            }
          //  dataGridView1.Rows[11].Cells[0].Value = "Системы";
          //  dataGridView1.Rows[11].Cells[1].Value = "Решение";
        }

        int Agolosa;
        int Bgolosa;
        int Cgolosa;
        int Dgolosa;   

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void otv4_Click(object sender, EventArgs e)
        {
            Golosa.Clear();
            Agolosa = 0;
            Bgolosa = 0;
            Cgolosa = 0;
            Dgolosa = 0;
            Golosa.Add(golos1.Text); Golosa.Add(golos2.Text); Golosa.Add(golos3.Text); Golosa.Add(golos4.Text); Golosa.Add(golos5.Text); Golosa.Add(golos6.Text); Golosa.Add(golos7.Text); Golosa.Add(golos8.Text); Golosa.Add(golos9.Text); Golosa.Add(golos10.Text); Golosa.Add(golos11.Text);
            int[] golosausers = new int[4] { Agolosa, Bgolosa, Cgolosa, Dgolosa };
            for (int i = 0; i < FirstMesto.Count; i++)
            {
                for (int n = 0; n < potentialwinners.Length; n++)
                {
                    if (FirstMesto[i] == potentialwinners[n])
                    {
                        golosausers[n] += Convert.ToInt32(Golosa[i]) * 4;
                    }
                    else if (SecondMesto[i] == potentialwinners[n])
                    {
                        golosausers[n] += Convert.ToInt32(Golosa[i]) * 3;
                    }
                    else if (ThirdMesto[i] == potentialwinners[n])
                    {
                        golosausers[n] += Convert.ToInt32(Golosa[i]) * 2;
                    }
                    else if (FourthMesto[i] == potentialwinners[n])
                    {
                        golosausers[n] += Convert.ToInt32(Golosa[i]) * 1;
                    }
                }              
            }
            string winner = "";
            int max = 0;
            for (int i = 0; i < golosausers.Length; i++)
            {
                if (golosausers[i] > max)
                {
                    winner = potentialwinners[i];
                    max = golosausers[i];
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Golosa.Clear();
            Agolosa = 0;
            Bgolosa = 0;
            Cgolosa = 0;
            Dgolosa = 0;
            Golosa.Add(golos1.Text); Golosa.Add(golos2.Text); Golosa.Add(golos3.Text); Golosa.Add(golos4.Text); Golosa.Add(golos5.Text); Golosa.Add(golos6.Text); Golosa.Add(golos7.Text); Golosa.Add(golos8.Text); Golosa.Add(golos9.Text); Golosa.Add(golos10.Text); Golosa.Add(golos11.Text);
            int[] golosausers = new int[4] { Agolosa, Bgolosa, Cgolosa, Dgolosa };
            for (int i = 0; i < FirstMesto.Count; i++)
            {
                for (int n = 0; n < potentialwinners.Length; n++)
                {
                    if (FirstMesto[i] == potentialwinners[n])
                    {
                        golosausers[n] += Convert.ToInt32(Golosa[i]);
                    }
                }
            }
            string winner = "";
            int max = 0;
            for (int i = 0; i < golosausers.Length; i++)
            {
                if (golosausers[i] > max)
                {
                    winner = potentialwinners[i];
                    max = golosausers[i];
                }
            }
            string secondewinner = "";
            int secondemax = 0;
            for (int i = 0; i < golosausers.Length; i++)
            {
                if (golosausers[i] > secondemax && winner != potentialwinners[i])
                {
                    secondewinner = potentialwinners[i];
                    secondemax = golosausers[i];
                }
            }
            int winpred1 = 0;
            int winpred2 = 0;
            for (int i = 0; i < FirstMesto.Count; i++)
            {
                if (FirstMesto[i] == winner)
                {
                   winpred1 += Convert.ToInt32(Golosa[i]);
                }
                if (SecondMesto[i] == winner)
                {
                    if (ThirdMesto[i] == secondewinner || FourthMesto[i] == secondewinner)
                    {
                        winpred1 += Convert.ToInt32(Golosa[i]);
                    }
                    else
                    {
                        winpred1 += Convert.ToInt32(Golosa[i]);
                    }
                }
                if (ThirdMesto[i] == winner)
                {
                    if (FourthMesto[i] == secondewinner)
                    {
                        winpred1 += Convert.ToInt32(Golosa[i]);
                    }
                    else
                    {
                        winpred2 += Convert.ToInt32(Golosa[i]);
                    }
                }
                if (FourthMesto[i] == winner)
                {
                    winpred2 += Convert.ToInt32(Golosa[i]);
                }
            }
            string realwinner;
            if (winpred1 > winpred2)
            {
                realwinner = winner;
            }
            else
            {
                realwinner = secondewinner;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void otv3_Click(object sender, EventArgs e)
        {

            Golosa.Clear();
            Agolosa = 0;
            Bgolosa = 0;
            Cgolosa = 0;
            Dgolosa = 0;
            Golosa.Add(golos1.Text); Golosa.Add(golos2.Text); Golosa.Add(golos3.Text); Golosa.Add(golos4.Text); Golosa.Add(golos5.Text); Golosa.Add(golos6.Text); Golosa.Add(golos7.Text); Golosa.Add(golos8.Text); Golosa.Add(golos9.Text); Golosa.Add(golos10.Text); Golosa.Add(golos11.Text);
            int[] golosausers = new int[4] { Agolosa, Bgolosa, Cgolosa, Dgolosa };
            for (int i = 0; i < FirstMesto.Count; i++)
            {
                if (FirstMesto[i] == "A")
                {
                    if (SecondMesto[i] == "B" || ThirdMesto[i] == "B" || FourthMesto[i] == "B")
                    {
                        Agolosa += Convert.ToInt32(Golosa[i]);
                    }
                }
                if (SecondMesto[i] == "A")
                {
                    if (ThirdMesto[i] == "B" || FourthMesto[i] == "B")
                    {
                        Agolosa += Convert.ToInt32(Golosa[i]);
                    }
                    else
                    {
                        Bgolosa += Convert.ToInt32(Golosa[i]);
                    }
                }
                if (ThirdMesto[i] == "A")
                {
                    if (FourthMesto[i] == "B")
                    {
                        Agolosa += Convert.ToInt32(Golosa[i]);
                    }
                    else
                    {
                        Bgolosa += Convert.ToInt32(Golosa[i]);
                    }
                }
                if (FourthMesto[i] == "A")
                {
                    Bgolosa += Convert.ToInt32(Golosa[i]);
                }
            }

        }

        private void otv5_Click(object sender, EventArgs e)
        {
            Golosa.Clear();
            Agolosa = 0;
            Bgolosa = 0;
            Cgolosa = 0;
            Dgolosa = 0;
            Golosa.Add(golos1.Text); Golosa.Add(golos2.Text); Golosa.Add(golos3.Text); Golosa.Add(golos4.Text); Golosa.Add(golos5.Text); Golosa.Add(golos6.Text); Golosa.Add(golos7.Text); Golosa.Add(golos8.Text); Golosa.Add(golos9.Text); Golosa.Add(golos10.Text); Golosa.Add(golos11.Text);
            for (int i = 0; i < FirstMesto.Count; i++)
            {
                if (FirstMesto[i] == "B" || SecondMesto[i] == "B")
                {
                    Bgolosa += Convert.ToInt32(Golosa[i]);
                }
                else if (FirstMesto[i] == "C")
                {
                    Cgolosa += Convert.ToInt32(Golosa[i]);
                }
                else if (FirstMesto[i] == "D")
                {
                    Dgolosa += Convert.ToInt32(Golosa[i]);
                }
            }
            int[] golosausers = new int[4] { Agolosa, Bgolosa, Cgolosa, Dgolosa };
            string winner = "";
            int max = 0;
            for (int i = 0; i < golosausers.Length; i++)
            {
                if (golosausers[i] > max)
                {
                    winner = potentialwinners[i];
                    max = golosausers[i];
                }
            }
            string secondewinner = "";
            int secondemax = 0;
            for (int i = 0; i < golosausers.Length; i++)
            {
                if (golosausers[i] > secondemax && winner != potentialwinners[i])
                {
                    secondewinner = potentialwinners[i];
                    secondemax = golosausers[i];
                }
            }
            Agolosa = 0;
            Bgolosa = 0;
            for (int i = 0; i < FirstMesto.Count; i++)
            {
                if (FirstMesto[i] == winner)
                {
                    if (SecondMesto[i] == secondewinner || ThirdMesto[i] == secondewinner || FourthMesto[i] == secondewinner)
                    {
                        Agolosa += Convert.ToInt32(Golosa[i]);
                    }
                }
                if (SecondMesto[i] == winner)
                {
                    if (ThirdMesto[i] == secondewinner || FourthMesto[i] == secondewinner)
                    {
                        Agolosa += Convert.ToInt32(Golosa[i]);
                    }
                    else
                    {
                        Bgolosa += Convert.ToInt32(Golosa[i]);
                    }
                }
                if (ThirdMesto[i] == winner)
                {
                    if (FourthMesto[i] == secondewinner)
                    {
                        Agolosa += Convert.ToInt32(Golosa[i]);
                    }
                    else
                    {
                        Bgolosa += Convert.ToInt32(Golosa[i]);
                    }
                }
                if (FourthMesto[i] == winner)
                {
                    Bgolosa += Convert.ToInt32(Golosa[i]);
                }
            }
            string realwinner;
            if (Agolosa > Bgolosa)
            {
                realwinner = winner;
            }
            else
            {
                realwinner = secondewinner;
            }    
        }


        private void Savetxt_Click(object sender, EventArgs e)
        {
            string path = @"save.txt";
            FileStream file = new FileStream(path, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(DateTime.Now);
          
            writer.WriteLine("___________________________");
            writer.Close();
            System.Diagnostics.Process.Start(@"save.txt");

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //  Golosa.Add(golos1.Text); Golosa.Add(golos2.Text); Golosa.Add(golos3.Text); Golosa.Add(golos4.Text); Golosa.Add(golos5.Text); Golosa.Add(golos6.Text); Golosa.Add(golos7.Text); Golosa.Add(golos8.Text); Golosa.Add(golos9.Text); Golosa.Add(golos10.Text); Golosa.Add(golos11.Text);
            //for (int i = 0; i < 11; i++)
            //{
            //    dataGridView1.Rows[i].Cells[1].Value = "привет";
            //}

            dataGridView2.Rows[0].Cells[1].Value = "ПЗ-1";
            dataGridView2.Rows[0].Cells[2].Value = "Урок 3";
            dataGridView2.Rows[0].Cells[3].Value = "ПЗ-2";
            dataGridView2.Rows[0].Cells[4].Value = "Урок 4";
            dataGridView2.Rows[0].Cells[5].Value = "Доп. задания на праздники";
            dataGridView2.Rows[0].Cells[6].Value = "доп. задание 1";
            dataGridView2.Rows[0].Cells[7].Value = "Урок 5";
            dataGridView2.Rows[0].Cells[8].Value = "Урок 6";
            dataGridView2.Rows[0].Cells[9].Value = "урок 7";
            dataGridView2.Rows[0].Cells[10].Value = "Доп. задание 2";
            dataGridView2.Rows[0].Cells[11].Value = "ПЗ-4(БД для ПЗ)";
            dataGridView2.Rows[0].Cells[12].Value = "Урок 7";
            dataGridView2.Rows[0].Cells[13].Value = "ПЗ-5";
            dataGridView2.Rows[0].Cells[14].Value = "Урок 8";
            dataGridView2.Rows[0].Cells[15].Value = "ПЗ-6";
            dataGridView2.Rows[0].Cells[16].Value = "Опрос";


            string fileCSV = "";
            for (int j = 0; j < dataGridView1.ColumnCount; j++)
            {
                fileCSV += Convert.ToString(dataGridView1.Columns[j].HeaderText) + ";";
            }
            fileCSV += "\t\n";

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    fileCSV += Convert.ToString(dataGridView1[j, i].Value) + ";";
                }
                fileCSV += "\t\n";
            }
            StreamWriter wr = new StreamWriter("excelresult.xls", false, Encoding.GetEncoding("windows-1251"));
            wr.Write(fileCSV);
            wr.Close();
            System.Diagnostics.Process.Start(@"excelresult.xls");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Spravka newForm = new Spravka();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Golosa.Add(golos1.Text); Golosa.Add(golos2.Text); Golosa.Add(golos3.Text); Golosa.Add(golos4.Text); Golosa.Add(golos5.Text); Golosa.Add(golos6.Text); Golosa.Add(golos7.Text); Golosa.Add(golos8.Text); Golosa.Add(golos9.Text); Golosa.Add(golos10.Text); Golosa.Add(golos11.Text);
            for (int i = 0; i < 11; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = Golosa[i];
            }
            //dataGridView1.Rows[12].Cells[0].Value = label5.Text;
            //dataGridView1.Rows[13].Cells[0].Value = "2) лучшие два выходят во второй тур и победитель определяется исходя из парных предпочтений";
            //dataGridView1.Rows[14].Cells[0].Value = label16.Text;
            //dataGridView1.Rows[15].Cells[0].Value = label7.Text;
            //dataGridView1.Rows[16].Cells[0].Value = "5) в каждом туре отсеивается один, последний, кандидат";
            //dataGridView1.Rows[12].Cells[1].Value = Otvet1.Text;
            //dataGridView1.Rows[13].Cells[1].Value = otvet2.Text;
            //dataGridView1.Rows[14].Cells[1].Value = otvet3.Text;
            //dataGridView1.Rows[15].Cells[1].Value = otvet4.Text;
            //dataGridView1.Rows[16].Cells[1].Value = otvet5.Text;
            SqlConnection con4 = new SqlConnection(@"Data Source = " + server + "; Initial catalog = Tpr11; integrated security = SSPI");
            con4.Open();
            for (int i = 0; i < 16; i++)
            {
                if (i < 11)
                {
                    SqlCommand com4 = new SqlCommand("Update Vibori SET[Предпочтения] = '" + dataGridView1.Rows[i].Cells[0].Value + "', [Голоса] = '" + dataGridView1.Rows[i].Cells[1].Value + "' Where[Код] = " + i + "", con4);
                    SqlDataReader r4 = com4.ExecuteReader();
                    r4.Close();
                }
                else if(i > 11)
                {
                    SqlCommand com4 = new SqlCommand("Update Vibori SET[Система] = '" + dataGridView1.Rows[i].Cells[0].Value + "', [Решение] = '" + dataGridView1.Rows[i].Cells[1].Value  + "' Where[Код] = " + Convert.ToInt32(i - 11) + "", con4);
                    SqlDataReader r4 = com4.ExecuteReader();
                    r4.Close();
                }                        
            }
            MessageBox.Show("Данные успешно внесены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Columns.Add(textBox1.Text, "Токарчук Андрей");
            dataGridView2.Rows.Add(textBox2.Text, "ПЗ-1");
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();

        }
    }
}
