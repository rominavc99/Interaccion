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

namespace Interaccion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           

            btnMiBoton.Click += BtnMiBoton_Click;
        }

        private void BtnMiBoton_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "Adios Mundo Cruel";
            lblHolaMundo.FontSize = 30;
            lblHolaMundo.Foreground = Brushes.Red;
        }

        private void BtnMiBoton2_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "Adios Mundo Cruel x2";
            lblHolaMundo.FontSize = 50;
            lblHolaMundo.Foreground = Brushes.Black;

        }

        private void BtnMiBoton3_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "Adios Mundo Cruel x3";
            lblHolaMundo.FontSize = 150;
            lblHolaMundo.Foreground = Brushes.Blue;
        }
    }
}
