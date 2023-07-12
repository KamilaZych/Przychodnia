using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    [Serializable]

    public class Pracownik
    {
        private string imię;
        private string nazwisko;
        private string rok_rozpoczęcia_pracy;
        private string czynności_medyczne;
        private List<string> lista_czynności_medycznych_danego_lekarza = new List<string>();  
        private static List<Pracownik> lista_pracowników = new List<Pracownik>();

        public object[] Values => new object[] { imię, nazwisko, rok_rozpoczęcia_pracy, czynności_medyczne };

        public string Imię { get => imię; set => imię = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Rok_rozpoczęcia_pracy { get => rok_rozpoczęcia_pracy; set => rok_rozpoczęcia_pracy = value; }
        public string Czynności_medyczne { get => czynności_medyczne; set => czynności_medyczne = value; }
        public List<string> Lista_czynności_medycznych_danego_lekarza { get => lista_czynności_medycznych_danego_lekarza; set => lista_czynności_medycznych_danego_lekarza = value; }
        public static List<Pracownik> Lista_pracowników { get => lista_pracowników; set => lista_pracowników = value; }

        public override string ToString()
        {
            return imię + " " + nazwisko;
        }
    }
}
