using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Przychodnia
{
    public class Serializacja
    {
        private static string ścieżka = string.Empty;

        public static void SerializacjaForms()
        {
            const string filter = "Pliki naszej aplikacji|*.pna";
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = filter;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                FileStream fileStream = new FileStream(openFileDialog.FileName,
                    FileMode.Open, FileAccess.Read);

                Czynność_medyczna.Lista_wszystkich_czynności_medycznych.Clear();
                Gabinet.Lista_gabinetów.Clear();
                Pacjent.Lista_pacjentów.Clear();
                Pracownik.Lista_pracowników.Clear();
                Grafik.Lista_grafik.Clear();
                Zaplanowana_wizyta.Lista_zaplanowanych_wizyt.Clear();

                List<Czynność_medyczna> czynności_medyczne = (List<Czynność_medyczna>)binaryFormatter.Deserialize(fileStream);
                List<Gabinet> numery_gabinetów = (List<Gabinet>)binaryFormatter.Deserialize(fileStream);
                List<Pacjent> pacjenci = (List<Pacjent>)binaryFormatter.Deserialize(fileStream);
                List<Pracownik> pracownicy = (List<Pracownik>)binaryFormatter.Deserialize(fileStream);
                List<Grafik> grafiki = (List<Grafik>)binaryFormatter.Deserialize(fileStream);
                List<Zaplanowana_wizyta> zaplanowane_wizyty = (List<Zaplanowana_wizyta>)binaryFormatter.Deserialize(fileStream);

                
                foreach (Czynność_medyczna czynność_medyczna in czynności_medyczne)
                    Czynność_medyczna.Lista_wszystkich_czynności_medycznych.Add(czynność_medyczna);

                foreach (Gabinet numer_gabinetu in numery_gabinetów)
                    Gabinet.Lista_gabinetów.Add(numer_gabinetu);

                foreach (Pacjent pacjent in pacjenci)
                    Pacjent.Lista_pacjentów.Add(pacjent);

                foreach (Pracownik pracownik in pracownicy)
                    Pracownik.Lista_pracowników.Add(pracownik);

                foreach (Grafik grafik in grafiki)
                    Grafik.Lista_grafik.Add(grafik);

                foreach (Zaplanowana_wizyta zaplanowana_wizyta in zaplanowane_wizyty)
                    Zaplanowana_wizyta.Lista_zaplanowanych_wizyt.Add(zaplanowana_wizyta);


                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się odczytać danych.\n" + ex.Message);
            }
        }
        public static void SerializacjaWeb()
        {
            if (ścieżka == string.Empty)
            {
                try
                {
                    Thread newThread = new Thread(new ThreadStart(ThreadMethod));
                    newThread.SetApartmentState(ApartmentState.STA);
                    newThread.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie udało się odczytać danych.\n" + ex.Message);
                }
            }
            else
            {
                try
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    FileStream fileStream = new FileStream(ścieżka,
                        FileMode.Open, FileAccess.Read);

                    Czynność_medyczna.Lista_wszystkich_czynności_medycznych.Clear();
                    Gabinet.Lista_gabinetów.Clear();
                    Pacjent.Lista_pacjentów.Clear();
                    Pracownik.Lista_pracowników.Clear();
                    Grafik.Lista_grafik.Clear();
                    Zaplanowana_wizyta.Lista_zaplanowanych_wizyt.Clear();

                    List<Czynność_medyczna> czynności_medyczne = (List<Czynność_medyczna>)binaryFormatter.Deserialize(fileStream);
                    List<Gabinet> numery_gabinetów = (List<Gabinet>)binaryFormatter.Deserialize(fileStream);
                    List<Pacjent> pacjenci = (List<Pacjent>)binaryFormatter.Deserialize(fileStream);
                    List<Pracownik> pracownicy = (List<Pracownik>)binaryFormatter.Deserialize(fileStream);
                    List<Grafik> grafiki = (List<Grafik>)binaryFormatter.Deserialize(fileStream);
                    List<Zaplanowana_wizyta> zaplanowane_wizyty = (List<Zaplanowana_wizyta>)binaryFormatter.Deserialize(fileStream);

                    foreach (Czynność_medyczna czynność_medyczna in czynności_medyczne)
                        Czynność_medyczna.Lista_wszystkich_czynności_medycznych.Add(czynność_medyczna);

                    foreach (Gabinet numer_gabinetu in numery_gabinetów)
                        Gabinet.Lista_gabinetów.Add(numer_gabinetu);

                    foreach (Pacjent pacjent in pacjenci)
                        Pacjent.Lista_pacjentów.Add(pacjent);

                    foreach (Pracownik pracownik in pracownicy)
                        Pracownik.Lista_pracowników.Add(pracownik);

                    foreach (Grafik grafik in grafiki)
                        Grafik.Lista_grafik.Add(grafik);

                    foreach (Zaplanowana_wizyta zaplanowana_wizyta in zaplanowane_wizyty)
                        Zaplanowana_wizyta.Lista_zaplanowanych_wizyt.Add(zaplanowana_wizyta);

                    fileStream.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie udało się odczytać danych.\n" + ex.Message);
                }
            }
        }
        public static void DeserializacjaForms()
        {
            const string filter = "Pliki naszej aplikacji|*.pna";
            DialogResult dialogResult = MessageBox.Show("Czy chcesz zapisać dane?", "Zamykanie aplikacji",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel || dialogResult == DialogResult.No)
            {
                return;
            }

            try
            {
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = filter;
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                FileStream fileStream = new FileStream(saveFileDialog.FileName,
                    FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                List<Czynność_medyczna> czynności_medyczne = new List<Czynność_medyczna>();
                List<Gabinet> numery_gabinetów = new List<Gabinet>(); ;
                List<Pacjent> pacjenci = new List<Pacjent>();
                List<Pracownik> pracownicy = new List<Pracownik>();
                List<Grafik> grafiki = new List<Grafik>();
                List<Zaplanowana_wizyta> zaplanowane_wizyty = new List<Zaplanowana_wizyta>();


                foreach (Czynność_medyczna czynność_medyczna in Czynność_medyczna.Lista_wszystkich_czynności_medycznych)
                    czynności_medyczne.Add(czynność_medyczna);

                foreach (Gabinet numer_gabinetu in Gabinet.Lista_gabinetów)
                    numery_gabinetów.Add(numer_gabinetu);

                foreach (Pacjent pacjent in Pacjent.Lista_pacjentów)
                    pacjenci.Add(pacjent);

                foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
                    pracownicy.Add(pracownik);

                foreach (Grafik grafik in Grafik.Lista_grafik)
                    grafiki.Add(grafik);

                foreach (Zaplanowana_wizyta zaplanowana_wizyta in Zaplanowana_wizyta.Lista_zaplanowanych_wizyt)
                    zaplanowane_wizyty.Add(zaplanowana_wizyta);

                binaryFormatter.Serialize(fileStream, czynności_medyczne);
                binaryFormatter.Serialize(fileStream, numery_gabinetów);
                binaryFormatter.Serialize(fileStream, pacjenci);
                binaryFormatter.Serialize(fileStream, pracownicy);
                binaryFormatter.Serialize(fileStream, grafiki);
                binaryFormatter.Serialize(fileStream, zaplanowane_wizyty);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać danych.\n" + ex.Message);
            }
        }
        public static void DeserializacjaWeb()
        {
            try
            {
                FileStream fileStream = new FileStream(ścieżka,
                    FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                List<Czynność_medyczna> czynności_medyczne = new List<Czynność_medyczna>();
                List<Gabinet> numery_gabinetów = new List<Gabinet>(); ;
                List<Pacjent> pacjenci = new List<Pacjent>();
                List<Pracownik> pracownicy = new List<Pracownik>();
                List<Grafik> grafiki = new List<Grafik>();
                List<Zaplanowana_wizyta> zaplanowane_wizyty = new List<Zaplanowana_wizyta>();


                foreach (Czynność_medyczna czynność_medyczna in Czynność_medyczna.Lista_wszystkich_czynności_medycznych)
                    czynności_medyczne.Add(czynność_medyczna);

                foreach (Gabinet numer_gabinetu in Gabinet.Lista_gabinetów)
                    numery_gabinetów.Add(numer_gabinetu);

                foreach (Pacjent pacjent in Pacjent.Lista_pacjentów)
                    pacjenci.Add(pacjent);

                foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
                    pracownicy.Add(pracownik);

                foreach (Grafik grafik in Grafik.Lista_grafik)
                    grafiki.Add(grafik);

                foreach (Zaplanowana_wizyta zaplanowana_wizyta in Zaplanowana_wizyta.Lista_zaplanowanych_wizyt)
                    zaplanowane_wizyty.Add(zaplanowana_wizyta);

                binaryFormatter.Serialize(fileStream, czynności_medyczne);
                binaryFormatter.Serialize(fileStream, numery_gabinetów);
                binaryFormatter.Serialize(fileStream, pacjenci);
                binaryFormatter.Serialize(fileStream, pracownicy);
                binaryFormatter.Serialize(fileStream, grafiki);
                binaryFormatter.Serialize(fileStream, zaplanowane_wizyty);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać danych.\n" + ex.Message);
            }
        }
        static void ThreadMethod()
        {
            const string filter = "Pliki naszej aplikacji|*.pna";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filter;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            FileStream fileStream = new FileStream(openFileDialog.FileName,
                FileMode.Open, FileAccess.Read);
            ścieżka = openFileDialog.FileName;
            
            Czynność_medyczna.Lista_wszystkich_czynności_medycznych.Clear();
            Gabinet.Lista_gabinetów.Clear();
            Pacjent.Lista_pacjentów.Clear();
            Pracownik.Lista_pracowników.Clear();
            Grafik.Lista_grafik.Clear();
            Zaplanowana_wizyta.Lista_zaplanowanych_wizyt.Clear();

            List<Czynność_medyczna> czynności_medyczne = (List<Czynność_medyczna>)binaryFormatter.Deserialize(fileStream);
            List<Gabinet> numery_gabinetów = (List<Gabinet>)binaryFormatter.Deserialize(fileStream);
            List<Pacjent> pacjenci = (List<Pacjent>)binaryFormatter.Deserialize(fileStream);
            List<Pracownik> pracownicy = (List<Pracownik>)binaryFormatter.Deserialize(fileStream);
            List<Grafik> grafiki = (List<Grafik>)binaryFormatter.Deserialize(fileStream);
            List<Zaplanowana_wizyta> zaplanowane_wizyty = (List<Zaplanowana_wizyta>)binaryFormatter.Deserialize(fileStream);

            foreach (Czynność_medyczna czynność_medyczna in czynności_medyczne)
                Czynność_medyczna.Lista_wszystkich_czynności_medycznych.Add(czynność_medyczna);

            foreach (Gabinet numer_gabinetu in numery_gabinetów)
                Gabinet.Lista_gabinetów.Add(numer_gabinetu);

            foreach (Pacjent pacjent in pacjenci)
                Pacjent.Lista_pacjentów.Add(pacjent);

            foreach (Pracownik pracownik in pracownicy)
                Pracownik.Lista_pracowników.Add(pracownik);

            foreach (Grafik grafik in grafiki)
                Grafik.Lista_grafik.Add(grafik);

            foreach (Zaplanowana_wizyta zaplanowana_wizyta in zaplanowane_wizyty)
                Zaplanowana_wizyta.Lista_zaplanowanych_wizyt.Add(zaplanowana_wizyta);

            fileStream.Close();
        }
    }
}
