using PlayersS.ViewModel;
using System.Windows;

namespace PlayersS
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SzukajZ_Click(object sender, RoutedEventArgs e)
        {
            Funkcje.SImie(WprowadzanieImienia.Text, Tabela);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void SzukajK_Click(object sender, RoutedEventArgs e)
        {
            Funkcje.SKraj(WprowadzenieKraju.Text, Tabela);
        }

        private void PodajIlosc_Click(object sender, RoutedEventArgs e)
        {
            IloscZawodnikow.Text = Funkcje.Ilosc.ToString();
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Funkcje.SaveIt();


        }
        private void Wczytaj_Click(object sender, RoutedEventArgs e)
        {
            Funkcje.Wczytaj(Tabela);
        }


    }
}
