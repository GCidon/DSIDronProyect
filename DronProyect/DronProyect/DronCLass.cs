using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;


namespace DronProyect
{

    public class DronClass
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public Image Img;
        public string Explicacion { get; set; }

        public DronClass() { }

        public DronClass(int Id_, string Nombre_, string Imagen_, int X_, int Y_)
        {
            Id = Id_;
            Nombre = Nombre_;
            Imagen = Imagen_;
            Img = null;
            Explicacion = "";
        }
    }

    public class DronData
    {
        private static List<DronClass> Drones = new List<DronClass>()
        {
            new DronClass()
            {
                Id = 1,
                Nombre = "Annihilator",
                Imagen = "Assets\\Drones\\1.png",
                Explicacion = "Este dron esta bastante decente,\n pero en verdad no es para tanto",
            },
            new DronClass()
            {
                Id = 2,
                Nombre = "Hurricane",
                Imagen = "Assets\\Drones\\2.png",
                Explicacion = "Este dron esta bastante decente,\n pero en verdad no es para tanto",
            },
            new DronClass()
            {
                Id = 3,
                Nombre = "Jose Manuel",
                Imagen = "Assets\\Drones\\3.png",
                Explicacion = "Este dron esta bastante decente,\n pero en verdad no es para tanto",
            },
            new DronClass()
            {
                Id = 4,
                Nombre = "Beast",
                Imagen = "Assets\\Drones\\4.png",
                Explicacion = "Este dron esta bastante decente,\n pero en verdad no es para tanto",
            }
        };

        public static IList<DronClass> GetAllDrones()
        {
            return Drones;
        }

        public static DronClass GetDronById(int id)
        {
            return Drones[id];
        }
    }
}