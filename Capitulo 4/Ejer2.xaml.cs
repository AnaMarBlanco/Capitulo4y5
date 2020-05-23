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
    /// Interaction logic for Ejer4.xaml
    /// </summary>
    public partial class Ejer2 : Window
    {
        public Ejer2()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            int bas= Convert.ToInt32(Base.Text);
            int exp = Convert.ToInt32(Exponente.Text);
            int res=1;
            for (int i = 0; i < exp; i++)
            {
                res *= bas;
            }
            Resultado.Text = res.ToString();
        }
    }
}
