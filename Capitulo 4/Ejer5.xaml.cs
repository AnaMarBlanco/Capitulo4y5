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
    /// Interaction logic for Ejer5.xaml
    /// </summary>
    public partial class Ejer5 : Window
    {
        public Ejer5()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            int[] Edades = new int[10];

            Edades[0] = Convert.ToInt32(Edad1.Text);
            Edades[1] = Convert.ToInt32(Edad2.Text);
            Edades[2] = Convert.ToInt32(Edad3.Text);
            Edades[3] = Convert.ToInt32(Edad4.Text);
            Edades[4] = Convert.ToInt32(Edad5.Text);
            Edades[5] = Convert.ToInt32(Edad6.Text);
            Edades[6] = Convert.ToInt32(Edad7.Text);
            Edades[7] = Convert.ToInt32(Edad8.Text);
            Edades[8] = Convert.ToInt32(Edad9.Text);
            Edades[9] = Convert.ToInt32(Edad10.Text);

            int prom = 0;
            int sum = 0;
            int max = 0;
            int min = 3000;

            for (int i = 0; i < 10; i++)
            {
                sum += Edades[i];
                if (Edades[i] > max)
                    max = Edades[i];

                if (Edades[i] < min)
                    min = Edades[i];
            }
            prom = sum / 10;
            Promedio.Text = prom.ToString();
            Mayor.Text = max.ToString();
            Menor.Text = min.ToString();
            

        }
    }
}
