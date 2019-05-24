using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DronProyect
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Config : Page
    {

        bool mandoactive = false;
        bool tecladoactive = false;
        bool hudactive = false;

        public Config()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        private void backtoMain(object sender, RoutedEventArgs e)
        {
            mando.Opacity = 0;
            teclado.Opacity = 0;
            hud.Opacity = 0;
            hudImage.Opacity = 0;

            mandoactive = false;
            tecladoactive = false;
            hudactive = false;

            this.Frame.Navigate(typeof(MainPage));
        }

        private void mandoButton(object sender, RoutedEventArgs e)
        {
            if (!mandoactive)
            {
                mando.Opacity = 100;
                teclado.Opacity = 0;
                hud.Opacity = 0;
                hudImage.Opacity = 0;
                mandoactive = true;
                tecladoactive = false;
                hudactive = false;
            } else
            {
                mando.Opacity = 0;
                mandoactive = false;
            }
        }

        private void tecladoButton(object sender, RoutedEventArgs e)
        {
            if (!tecladoactive)
            {
                mando.Opacity = 0;
                teclado.Opacity = 100;
                hud.Opacity = 0;
                hudImage.Opacity = 0;
                mandoactive = false;
                tecladoactive = true;
                hudactive = false;
            }
            else
            {
                teclado.Opacity = 0;
                tecladoactive = false;
            }
        }

        private void hudButton(object sender, RoutedEventArgs e)
        {
            if (!hudactive)
            {
                mando.Opacity = 0;
                teclado.Opacity = 0;
                hud.Opacity = 100;
                hudImage.Opacity = 100;
                mandoactive = false;
                tecladoactive = false;
                hudactive = true;
            }
            else
            {
                hud.Opacity = 0;
                hudImage.Opacity = 0;
                hudactive = false;
            }
        }
    }
}
