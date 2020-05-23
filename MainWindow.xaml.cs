using Cap4ycap5.Capitulo_4;
using Cap4ycap5.Capitulo_5;
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

namespace Cap4ycap5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cap4Ejer1_Click(object sender, RoutedEventArgs e)
        {
            Ejer1 ventana = new Ejer1();
            ventana.ShowDialog();
        }

        private void Cap4Ejer2_Click(object sender, RoutedEventArgs e)
        {
            Ejer2 ventana = new Ejer2();
            ventana.ShowDialog();
        }

        private void Cap4Ejer5_Click(object sender, RoutedEventArgs e)
        {
            Ejer5 ventana = new Ejer5();
            ventana.ShowDialog();
        }

        private void Cap5Ejer4_Click(object sender, RoutedEventArgs e)
        {
            CEjer4 ventana = new CEjer4();
            ventana.ShowDialog();
        }

        private void Cap5Ejer5_Click(object sender, RoutedEventArgs e)
        {
            CEjer5 ventana = new CEjer5();
            ventana.ShowDialog();
        }

    }
}
