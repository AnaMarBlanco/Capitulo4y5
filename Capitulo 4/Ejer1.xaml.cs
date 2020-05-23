using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Cap4ycap5.Capitulo_4
{
    /// <summary>
    /// Interaction logic for Ejer1.xaml
    /// </summary>
    public partial class Ejer1 : Window
    {
        public Ejer1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            string result=String.Empty;
            int valor = Convert.ToInt32(Multiplicando.Text);
            int total;
            for (int i = 0; i <= 10; i++)
            {
                total = i * valor;
                result+=$" {valor} x {i} = {total} \n";
            }
            Tabla.Text = result;
        }
    }
}
