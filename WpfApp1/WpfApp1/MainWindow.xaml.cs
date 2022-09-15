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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ProkatEntities1 x1 = new ProkatEntities1();
            var s = x1.Сотрудники.ToList();
            foreach (var photo in s)
            {
                if (photo.Image_log.Length > 5)
                {
                    string path = $@"C:\PerfLogs\{photo.Image_log.Replace("\r\n", "")}";
                    byte[] imageInBytes = System.IO.File.ReadAllBytes(path);
                    photo.Image = imageInBytes;
                }
            }
            x1.SaveChanges();
        }
    }
}
