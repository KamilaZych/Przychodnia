using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    [Serializable]
    public class Zaplanowana_wizyta
    {
        private Pacjent pacjent;
        private string czynność_medyczna;
        private string pracownik;
        private DateTime data_wizyty;
        private DateTime godzina_wizyty;
        private int numer_gabinetu;
        private static List<Zaplanowana_wizyta> lista_zaplanowanych_wizyt = new List<Zaplanowana_wizyta>();
        public object[] Values => new object[] { pacjent, czynność_medyczna, pracownik, data_wizyty.ToShortDateString(), godzina_wizyty.ToShortTimeString(), numer_gabinetu };

        public Pacjent Pacjent { get => pacjent; set => pacjent = value; }
        public string Czynność_medyczna { get => czynność_medyczna; set => czynność_medyczna = value; }
        public string Pracownik { get => pracownik; set => pracownik = value; }
        public DateTime Data_wizyty { get => data_wizyty; set => data_wizyty = value; }
        public DateTime Godzina_wizyty { get => godzina_wizyty; set => godzina_wizyty = value; }
        public int Numer_gabinetu { get => numer_gabinetu; set => numer_gabinetu = value; }
        public static List<Zaplanowana_wizyta> Lista_zaplanowanych_wizyt { get => lista_zaplanowanych_wizyt; set => lista_zaplanowanych_wizyt = value; }
    }
}
