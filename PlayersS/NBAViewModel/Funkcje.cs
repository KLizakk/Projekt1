using Microsoft.Win32;
using Newtonsoft.Json;
using PlayersS.VIew;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;

using System.Reflection;
using PlayersS.Model;

namespace PlayersS.ViewModel
{
    public class Funkcje
    {
        
        public static int Ilosc;
        public static string Save;
        public async static void SImie(string WprowadzoneImie, DataGrid Testowa)
        {
            if (WprowadzoneImie != "")
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://api-nba-v1.p.rapidapi.com/players?search={WprowadzoneImie}"),
                    Headers =
    {
        { "X-RapidAPI-Key", "82e608ca0amshfb8be84d382c693p152ebejsn0ed3121d87c8" },
        { "X-RapidAPI-Host", "api-nba-v1.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {

                    response.EnsureSuccessStatusCode();



                    var body = await response.Content.ReadAsStringAsync();
                    
                    Save = body.ToString();
                    Testowa.Items.Clear();

                    var Wczytywanie = JsonConvert.DeserializeObject<Root>(body);

                    int LiczbaZawodników = Wczytywanie.response.Count();
                    if (LiczbaZawodników != 0)
                    {
                        // Dodajemy zawodników do tabeli
                        for (int i = 0; i < LiczbaZawodników; i++)
                        {
                            //tworzenie Zawodnika lepiej 
                            Zawodnik z = new Zawodnik();
                            z.firstname = Wczytywanie.response[i].lastname;
                            z.lastname = Wczytywanie.response[i].firstname;
                            z.nba = Wczytywanie.response[i].nba.start.ToString();
                            z.weight = Wczytywanie.response[i].weight.kilograms;
                            z.height = Wczytywanie.response[i].height.meters;
                            z.id = Wczytywanie.response[i].id;
                            z.college = Wczytywanie.response[i].college;
                            z.affiliation = Wczytywanie.response[i].affiliation;

                            //dodanie z do DataGridu
                            Testowa.Items.Add(z);
                        }
                        Ilosc = LiczbaZawodników;
                    }
                    //trzeba ogarnac co sie bedzie dzialo jak null przyjdzie 
                    else
                    {
                        // tu ma wyskakiwac okno bledu, ktore wyczysci pola i kaze wpisac jeszcze raz wartosci
                        ERROR();


                    }
                }



            }
            else
            {
                ERROR();
            }
        }
        public static async void SKraj(string kraj, DataGrid Testowa)
        {

            if (kraj != "")
            {


                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://api-nba-v1.p.rapidapi.com/players?country={kraj}"),
                    Headers =
    {
        { "X-RapidAPI-Key", "82e608ca0amshfb8be84d382c693p152ebejsn0ed3121d87c8" },
        { "X-RapidAPI-Host", "api-nba-v1.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {

                    response.EnsureSuccessStatusCode();



                    var body = await response.Content.ReadAsStringAsync();
                    Save = body;
                    if (string.IsNullOrEmpty(body) == false)
                    {
                        Testowa.Items.Clear();

                        var Wczytywanie = JsonConvert.DeserializeObject<Root>(body);

                        int LiczbaZawodników = Wczytywanie.response.Count();
                        if (LiczbaZawodników != 0)
                        {


                            // Dodajemy zawodników do tabeli
                            for (int i = 0; i < LiczbaZawodników; i++)
                            {
                                //tworzenie Zawodnika lepiej 
                                Zawodnik z = new Zawodnik();
                                z.firstname = Wczytywanie.response[i].lastname;
                                z.lastname = Wczytywanie.response[i].firstname;
                                z.nba = Wczytywanie.response[i].nba.start.ToString();
                                z.weight = Wczytywanie.response[i].weight.kilograms;
                                z.height = Wczytywanie.response[i].height.meters;
                                z.id = Wczytywanie.response[i].id;
                                z.college = Wczytywanie.response[i].college;
                                z.affiliation = Wczytywanie.response[i].affiliation;

                                //dodanie z do DataGridu
                                Testowa.Items.Add(z);
                            }
                            Ilosc = LiczbaZawodników;
                        }
                        else
                        {
                            ERROR();
                        }
                    }
                    else
                    {
                        ERROR();
                    }
                }
                //trzeba ogarnac co sie bedzie dzialo jak null przyjdzie 

                // tu ma wyskakiwac okno bledu, ktore wyczysci pola i kaze wpisac jeszcze raz wartosci





            }
            else
            {
                ERROR();
            }
        }

        public static void Wyjscie(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown();
        }

        public static void ERROR()
        {
            ErrorWindow errorWindow = new ErrorWindow();
            errorWindow.Show();



        }
        public static void SaveIt()
        {
            // Utwórz ścieżkę do katalogu projektu

            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = Path.Combine(projectDirectory, "Save.txt");
            File.WriteAllText(filePath, Save);

        }
        public static void Wczytaj(DataGrid Testowa)
        {
            Testowa.Items.Clear();
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = Path.Combine(projectDirectory, "Save.txt");
            Save = File.ReadAllText(filePath);
            var Wczytywanie = JsonConvert.DeserializeObject<Root>(Save);
            int LiczbaZawodników = Wczytywanie.response.Count();
            for (int i = 0; i < LiczbaZawodników; i++)
            {
                //tworzenie Zawodnika lepiej 
                Zawodnik z = new Zawodnik();
                z.firstname = Wczytywanie.response[i].lastname;
                z.lastname = Wczytywanie.response[i].firstname;
                z.nba = Wczytywanie.response[i].nba.start.ToString();
                z.weight = Wczytywanie.response[i].weight.kilograms;
                z.height = Wczytywanie.response[i].height.meters;
                z.id = Wczytywanie.response[i].id;
                z.college = Wczytywanie.response[i].college;
                z.affiliation = Wczytywanie.response[i].affiliation;

                //dodanie z do DataGridu
                Testowa.Items.Add(z);
            }
            Ilosc = LiczbaZawodników;


        }

    }
}
