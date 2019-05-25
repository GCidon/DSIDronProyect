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
        public string Attack { get; set; }
        public string Defense { get; set; }
        public string Speed { get; set; }

        public DronClass() { }

        public DronClass(int Id_, string Nombre_, string Imagen_)
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
                Explicacion = "Este dron esta bastante decente,\npero en verdad no es para tanto",
                Attack = "Mucho",
                Defense = "No tanta",
                Speed = "Decentilla"
            },
            new DronClass()
            {
                Id = 2,
                Nombre = "Hurricane",
                Imagen = "Assets\\Drones\\2.png",
                Explicacion = "Este mas o menos esta usable y tal,\npero tampoco te pases de listo",
                Attack = "Mas o menos",
                Defense = "Meh",
                Speed = "Una locura"
            },
            new DronClass()
            {
                Id = 3,
                Nombre = "Jose Manuel",
                Imagen = "Assets\\Drones\\3.png",
                Explicacion = "En realidad no se por que le pusimos este nombre,\npero al final a la gente le gusto",
                Attack = "Nada",
                Defense = "Menos",
                Speed = "Una broma"
            },
            new DronClass()
            {
                Id = 4,
                Nombre = "Beast",
                Imagen = "Assets\\Drones\\4.png",
                Explicacion = "Se uso en la tercera guerra mundial,\ny perdimos, asi que imaginate",
                Attack = "Un huevo",
                Defense = "A saco",
                Speed = "La mejor"
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