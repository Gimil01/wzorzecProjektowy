using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wzorzecProjektowy
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik tester = new Pracownik();
            tester.SetIDPracownik(453678635)
                .SetImieNazwisko("Rafał Ściblak")
                .SetNumerTelefonu(506190432)
                .SetWiek(25)
                .SetWynagrodzenie(5000);

            Pracodawca pracodawca = new Pracodawca();
            pracodawca.AddPracownik(tester);

            Console.WriteLine(pracodawca.GetListaPracownikow().ElementAt(0).GetImieNazwisko());
            Console.ReadKey();
        }
    }

    class Pracownik
    {
        long IDPracownik;
        string imieNazwisko;
        int numerTelefonu;
        byte wiek;
        int wynagrodzenie;


        public Pracownik()
        {
            IDPracownik = 0;
            imieNazwisko = "";
            numerTelefonu = 0;
            wiek = 0;
            wynagrodzenie = 0;
        }

        public Pracownik(long _IDPracownik,string _imieNazwisko, int _numerTelefonu, byte _wiek, int _wynagrodzenie)
        {
            IDPracownik = _IDPracownik;
            imieNazwisko = _imieNazwisko;
            numerTelefonu = _numerTelefonu;
            wiek = _wiek;
            wynagrodzenie = _wynagrodzenie;
        }

        //Gettery
        public long GetIDPracownik()
        {
            return IDPracownik;
        }

        public string GetImieNazwisko()
        {
            return imieNazwisko;
        }

        public int GetNumerTelefonu()
        {
            return numerTelefonu;
        }

        public byte GetWiek()
        {
            return wiek;
        }

        public int GetWynagrodzenie()
        {
            return wynagrodzenie;
        }

        //Settery
        public Pracownik SetIDPracownik(long _IDPracownik)
        {
            if (_IDPracownik < 0)
                throw new System.ArgumentException("ID musi być większe od 0.");
            else
                IDPracownik = _IDPracownik;
            return this;
        }

        public Pracownik SetImieNazwisko(string _imieNazwisko)
        {
            if (_imieNazwisko.Length < 10)
                throw new System.ArgumentException("Imię i nazwisko musi się składać z minimum 10 znaków.");
            else
                imieNazwisko = _imieNazwisko;
            return this;
        }

        public Pracownik SetNumerTelefonu(int _numerTelefonu)
        {
            numerTelefonu = _numerTelefonu;
            return this;
        }

        public Pracownik SetWiek(byte _wiek)
        {
            if (_wiek < 0 && _wiek > 100)
                throw new System.ArgumentException("Wiek musi być z przedziału od 0 do 100 lat.");
            else
                wiek = _wiek;
            return this;
        }

        public Pracownik SetWynagrodzenie(int _wynagrodzenie)
        {
            if (_wynagrodzenie < 2000)
                throw new System.ArgumentException("Wynagrodzenie nie może być mniejsze od 2000 zł.");
            else
                wynagrodzenie = _wynagrodzenie;
            return this;
        }
    }

    class Pracodawca
    {
        long IDPracodawca;
        List<Pracownik> listaPracownikow;

        public Pracodawca()
        {
            IDPracodawca = 0;
            listaPracownikow = new List<Pracownik>();
        }

        public Pracodawca(long _IDPracodawca, List<Pracownik> _listaPracownikow)
        {
            IDPracodawca = _IDPracodawca;
            listaPracownikow = _listaPracownikow;
        }

        public long GetIDPracownik()
        {
            return IDPracodawca;
        }

        public List<Pracownik> GetListaPracownikow()
        {
            return listaPracownikow;
        }

        public Pracodawca SetIDPracodawca(long _IDPracodawca)
        {
            if (_IDPracodawca < 0)
                throw new System.ArgumentException("ID musi być większe od 0.");
            else
                IDPracodawca = _IDPracodawca;
            return this;
        }

        public Pracodawca SetListaPracownikow(List<Pracownik> _listaPracownikow)
        {
            if (_listaPracownikow != null)
                listaPracownikow = _listaPracownikow;
            else
                throw new System.ArgumentException("Lista pracowników nie zawiera pracowników.");
            return this;
        }

        public Pracodawca AddPracownik(Pracownik _pracownik)
        {
            if(_pracownik != null)
                listaPracownikow.Add(_pracownik);
            else
                throw new System.ArgumentException("Argument jest niepoprawny.");
            return this;
        }
    }
}
