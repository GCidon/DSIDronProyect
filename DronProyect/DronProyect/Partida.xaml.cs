using System;
using System.IO;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Core;
using Windows.UI.Xaml.Media.Imaging;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DronProyect
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Partida : Page
    {

        bool aux = true;

        public Partida()
        {
            Window.Current.CoreWindow.KeyDown += Grid_KeyDown;
            this.InitializeComponent();
        }

        private void backtoMain(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Grid_KeyDown(CoreWindow sender, KeyEventArgs args)
        {
            switch (args.VirtualKey)
            {
                case Windows.System.VirtualKey.Escape:
                    this.Frame.Navigate(typeof(MainPage));
                    break;
                case Windows.System.VirtualKey.Up:
                    string s = "";
                    if (aux)
                    {
                        s = Directory.GetCurrentDirectory() + "\\Assets\\street2.jpg";
                        aux = !aux;
                    } else
                    {
                        s = Directory.GetCurrentDirectory() + "\\Assets\\street.jpg";
                        aux = !aux;
                    }
                    fondo.Source = new BitmapImage(new Uri(s));
                    break;
            }
        }
    }
}
