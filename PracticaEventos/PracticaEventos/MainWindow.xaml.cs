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

namespace PracticaEventos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Debug.WriteLine("iniciado");

            InitializeComponent();

            //this.Loaded += ElGrid_MouseDown;
        }

        private void ElGrid_KeyDown(object sender, KeyEventArgs e)
        {
            int columna = Grid.GetColumn(ElRectangulo);
            int fila = Grid.GetRow(ElRectangulo);

            if(e.Key == Key.Right)
            {
                if(columna < ElGrid.ColumnDefinitions.Count() - 1)
                {
                    Grid.SetColumn(ElRectangulo, ++columna);
                }
                else
                {
                    Grid.SetColumn(ElRectangulo, 0);
                }
            }
            else if(e.Key == Key.Left)
            {
                if (columna > 0)
                {
                    Grid.SetColumn(ElRectangulo, --columna);
                }
                else
                {
                    Grid.SetColumn(ElRectangulo, 7);
                }
            }
            else if(e.Key == Key.Down)
            {
                if (fila < ElGrid.RowDefinitions.Count() - 1)
                {
                    Grid.SetRow(ElRectangulo, ++fila);
                }
                else
                {
                    Grid.SetRow(ElRectangulo, 0);
                }
            }
            else if (e.Key == Key.Up)
            {
                if (fila > 0)
                {
                    Grid.SetRow(ElRectangulo, --fila);
                }
                else
                {
                    Grid.SetRow(ElRectangulo, 7);
                }
            }
        }

        private void ElGrid_MouseMove(object sender, MouseEventArgs e)
        {
            rt.Angle += 10;
        }

        private void ElGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ElGrid.Focusable = true;
            Keyboard.Focus(ElGrid);
        }

        private void ElRectanguloMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                Grid.SetColumn(ElRectangulo, 0);
                Grid.SetRow(ElRectangulo, 0);
                rt.Angle = 0;
            }
        }
    }
}
