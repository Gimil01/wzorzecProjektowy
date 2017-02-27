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
            tester.SetImieNazwisko("Rafał Ściblak")
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
        string imieNazwisko;
        int numerTelefonu;
        byte wiek;
        int wynagrodzenie;


        public Pracownik()
        {
            imieNazwisko = "";
            numerTelefonu = 0;
            wiek = 0;
            wynagrodzenie = 0;
        }

        public Pracownik(string _imieNazwisko, int _numerTelefonu, byte _wiek, int _wynagrodzenie)
        {
            imieNazwisko = _imieNazwisko;
            numerTelefonu = _numerTelefonu;
            wiek = _wiek;
            wynagrodzenie = _wynagrodzenie;
        }

        //Gettery
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
        List<Pracownik> listaPracownikow;

        public Pracodawca()
        {
            listaPracownikow = new List<Pracownik>();
        }

        public Pracodawca(List<Pracownik> _listaPracownikow)
        {
            listaPracownikow = _listaPracownikow;
        }

        public List<Pracownik> GetListaPracownikow()
        {
            return listaPracownikow;
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
