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
using System.Drawing;

namespace Ejercicio_P1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //ImageBrush img1, img2, img3;
        

        public MainWindow()
        {
            InitializeComponent();
            //img1 = (ImageBrush) this.Background;
            
        }

        private void BotonInvierte_Click(object sender, RoutedEventArgs e)
        {
            string textoDestino = CajaTexto.Text;
            string textoOrigen = "";

            foreach(char letra in textoDestino)
            {
                textoOrigen = letra + textoOrigen;
            }

            ResultadoConversion.Text = textoOrigen;
        }

        private void BotonMayusculas_Click(object sender, RoutedEventArgs e)
        {
            string textoOrigen = CajaTexto.Text.ToUpper();
            
            ResultadoConversion.Text = textoOrigen;
        }

        private void BotonBorra_Click(object sender, RoutedEventArgs e)
        {
            Window win = new Window();
            win.Content = "El texto ha sido borrado satisfactoriamente";
            win.Title = "Aviso";
            win.Height = 100;
            win.Width = 300;
            win.MaxHeight = 100;
            win.MaxWidth = 300;

            win.Show();

            CajaTexto.Text = "";
        }

        private void SiguienteImagen_Click(object sender, RoutedEventArgs e)
        {
            bool backgroundChange = false;
         

            /*while (!backgroundChange && indx < background.Count)
            {
                if (this.Background == background[indx])
                {
                    backgroundChange = true;
                }

                indx++;
            }

            if(indx == 3)
            {
                indx = 0;
            }

            this.Background = background[indx];*/
        }
    }
}
