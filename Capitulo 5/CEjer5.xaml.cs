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
    /// Interaction logic for CEjer5.xaml
    /// </summary>
    public partial class CEjer5 : Window
    {
        public CEjer5()
        {
            InitializeComponent();
        }

        string minumero(int num)
        {
            string valor = String.Empty;
            switch(num)
            {
                case 1: valor = "uno";
                    break;
                case 2:
                    valor = "dos";
                    break;
                case 3:
                    valor = "tres";
                    break;
                case 4:
                    valor = "cuatro";
                    break;
                case 5:
                    valor = "cinco";
                    break;
                case 6:
                    valor = "seis";
                    break;
                case 7:
                    valor = "siete";
                    break;
                case 8:
                    valor = "ocho";
                    break;
                case 9:
                    valor = "nueve";
                    break;
                case 10:
                    valor = "diez";
                    break;
                default:
                    valor = "cero";
                    break;
            }
            return valor;
        }
        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            int numero = Convert.ToInt32(Numero.Text);
            Resultado.Text = minumero(numero);
        }
    }
}
