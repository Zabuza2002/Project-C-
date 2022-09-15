using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp15
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        kursovayaEntities x = new kursovayaEntities();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
       



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            var u = x.T2.Single(a => a.name == t2.Text);
            int w = u.id;
            var u1 = x.T1.Max(d => d.id_);
            int f = Convert.ToInt32(t2.Text);
            string f1 = t3.Text;

            T1 tt1 = new T1 { id_ = u1 + 1, id_name = w, dat = f.ToString(), cot = f1 };

            x.T1.Add(tt1);
            x.SaveChanges();

            dg1.ItemsSource = x.T1.ToList();


        }

        private void dg1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
