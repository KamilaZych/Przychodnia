using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    [Serializable]

    public class Czynność_medyczna
    {
        private string nazwa_czynności_medycznej;
        private static List<Czynność_medyczna> lista_wszystkich_czynności_medycznych = new List<Czynność_medyczna>();

        public object[] Values => new object[] { nazwa_czynności_medycznej };

        public string Nazwa_czynności_medycznej { get => nazwa_czynności_medycznej; set => nazwa_czynności_medycznej = value; }
        public static List<Czynność_medyczna> Lista_wszystkich_czynności_medycznych { get => lista_wszystkich_czynności_medycznych; set => lista_wszystkich_czynności_medycznych = value; }
    }
}
