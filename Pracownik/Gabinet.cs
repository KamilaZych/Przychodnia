using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    [Serializable]

    public class Gabinet
    {
        private int numer_gabinetu;
        private static List<Gabinet> lista_gabinetów = new List<Gabinet>();

        public object[] Values => new object[] { numer_gabinetu };

        public int Numer_gabinetu { get => numer_gabinetu; set => numer_gabinetu = value; }
        public static List<Gabinet> Lista_gabinetów { get => lista_gabinetów; set => lista_gabinetów = value; }
    }   
}
