using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.System.Profile;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Gaming.Input;
using Windows.System;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DronProyect
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Dron : Page
    {
        public ObservableCollection<DronClass> ListaDrones { get; } = new ObservableCollection<DronClass>();
        protected int cont = 0;

        public Dron()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        protected override void OnNavigatedTo(NavigationEventArgs eventArgs)
        {
            if (ListaDrones != null)
                foreach (DronClass item in DronData.GetAllDrones())
                {   //Mi lista de Drones para el LisView
                    ListaDrones.Add(item);
                    Image img = new Image();
                    string s = Directory.GetCurrentDirectory() + "\\Assets\\Drones\\" + item.Id + ".png";
                    img.Source = new BitmapImage(new Uri(s));
                    img.Height = 50;
                    img.Width = 50;
                    item.Img = img;
                }

            asignaDron();

            base.OnNavigatedTo(eventArgs);
        }

        private void backtoMain(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void prevDron(object sender, RoutedEventArgs e)
        {
            if (cont > 0) cont--;
            else cont = 3;
            asignaDron();
        }

        private void nextDron(object sender, RoutedEventArgs e)
        {
            if (cont < 3) cont++;
            else cont = 0;
            asignaDron();
        }

        private void asignaDron()
        {
            fotoDron.Source = ListaDrones[cont].Img.Source;
            textDron.Text = ListaDrones[cont].Explicacion;
            nameDron.Text = ListaDrones[cont].Nombre;
            attackDron.Text = ListaDrones[cont].Attack;
            defenseDron.Text = ListaDrones[cont].Defense;
            speedDron.Text = ListaDrones[cont].Speed;
        }
    }
}
