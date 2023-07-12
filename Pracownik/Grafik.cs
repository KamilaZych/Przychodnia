using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    [Serializable]

    public class Grafik
    {
        private Pracownik pracownik;
        private DateTime data_rozpoczęcia_pracy = DateTime.Now;         //private DateTime godziny = .Today.;//całe godziny
        private DateTime data_zakończenia_pracy = DateTime.Now;        //jeden dzień, nie cyklicznie
        private int numer_gabinetu;
        private static List<Grafik> lista_grafik = new List<Grafik>();

        public object[] Values => new object[] { pracownik, data_rozpoczęcia_pracy.ToShortDateString()+"        "+data_rozpoczęcia_pracy.Hour+":00", 
                                                 data_zakończenia_pracy.ToShortDateString()+"       "+data_zakończenia_pracy.Hour+":00", numer_gabinetu };

        public Pracownik Pracownik { get => pracownik; set => pracownik = value; }
        public DateTime Data_rozpoczęcia_pracy { get => data_rozpoczęcia_pracy; set => data_rozpoczęcia_pracy = value;}
        public DateTime Data_zakończenia_pracy { get => data_zakończenia_pracy; set => data_zakończenia_pracy = value; }
        public int Numer_gabinetu { get => numer_gabinetu; set => numer_gabinetu = value; }
        public static List<Grafik> Lista_grafik { get => lista_grafik; set => lista_grafik = value; }
    }
}
