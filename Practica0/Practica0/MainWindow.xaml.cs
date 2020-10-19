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

namespace Practica0
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonFirst_Click(object sender, RoutedEventArgs e)
        {
            if(unaEtiqueta.Foreground == Brushes.Red)
            {
                unaEtiqueta.Foreground = Brushes.Blue;
            }
            else
            {
                unaEtiqueta.Foreground = Brushes.Red;
            }
        }

        private void ButtonSecond_Click(object sender, RoutedEventArgs e)
        {
            if(dosEtiqueta.Foreground == Brushes.Blue)
            {
                dosEtiqueta.Foreground = Brushes.Red;
            }
            else
            {
                dosEtiqueta.Foreground = Brushes.Blue;
            }
        }
    }
}
