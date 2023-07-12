using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    [Serializable]
    public class Pacjent
    {
        private string imię;
        private string nazwisko;
        private string pesel;
        private string rok_urodzenia;
        private string adres_zamieszkania;
        private string telefon_komórkowy;
        private string adres_email;
        private string osoby_upoważnione;
        private List<string> lista_osób_upoważnionych = new List<string>();
        private static List<Pacjent> lista_pacjentów = new List<Pacjent>();

        public object[] Values => new object[] { imię, nazwisko, pesel, rok_urodzenia, adres_zamieszkania, telefon_komórkowy, adres_email, osoby_upoważnione };

        public string Imię { get => imię; set => imię = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Pesel { get => pesel; set => pesel = value; }
        public string Rok_urodzenia { get => rok_urodzenia; set => rok_urodzenia = value; }
        public string Adres_zamieszkania { get => adres_zamieszkania; set => adres_zamieszkania = value; }
        public string Telefon_komórkowy { get => telefon_komórkowy; set => telefon_komórkowy = value; }
        public string Adres_email { get => adres_email; set => adres_email = value; }
        public string Osoby_upoważnione { get => osoby_upoważnione; set => osoby_upoważnione = value; }
        public List<string> Lista_osób_upoważnionych { get => lista_osób_upoważnionych; set => lista_osób_upoważnionych = value; }
        public static List<Pacjent> Lista_pacjentów { get => lista_pacjentów; set => lista_pacjentów = value; }
        
        public override string ToString()
        {
            return imię + " " + nazwisko;
        }
    }
}
