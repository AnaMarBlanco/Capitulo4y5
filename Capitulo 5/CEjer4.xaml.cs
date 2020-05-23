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

namespace Cap4ycap5.Capitulo_5
{
    /// <summary>
    /// Interaction logic for CEjer4.xaml
    /// </summary>
    public partial class CEjer4 : Window
    {
        public CEjer4()
        {
            InitializeComponent();
        }

        long Factoriales(long num)
        {
            long fact = 0;
            long num1 = num;
            long res=0;
            for (long i = num1; i >=0; i--)
            {
                res *= i;
            }
            fact = res;
            return fact;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            long num = Convert.ToInt64(Numero.Text);
            Factorial.Text = Factoriales(num).ToString();
        }
    }
}
