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

namespace Tema2_Imagen
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

        private void alta_radioButton_Checked(object sender, RoutedEventArgs e)
        {
            iverson_image.Opacity = 1;
        }

        private void media_radioButton_Checked(object sender, RoutedEventArgs e)
        {
            iverson_image.Opacity = 0.6;
        }

        private void baja_radioButton_Checked(object sender, RoutedEventArgs e)
        {
            iverson_image.Opacity = 0.3;
        }

        private void relleno_radioButton_Checked(object sender, RoutedEventArgs e)
        {
            iverson_image.Stretch = System.Windows.Media.Stretch.Fill;
        }

        private void uniforme_radioButton_Checked(object sender, RoutedEventArgs e)
        {
            iverson_image.Stretch = System.Windows.Media.Stretch.Uniform;
        }

        private void rellenoUniforme_radioButton_Checked(object sender, RoutedEventArgs e)
        {
            iverson_image.Stretch = System.Windows.Media.Stretch.UniformToFill;
        }

        private void sinAjuste_radioButton_Checked(object sender, RoutedEventArgs e)
        {
            iverson_image.Stretch = System.Windows.Media.Stretch.None;
        }
    }
}
