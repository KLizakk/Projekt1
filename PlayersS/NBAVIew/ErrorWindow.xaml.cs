﻿using System.Windows;

namespace PlayersS.VIew
{
    /// <summary>
    /// Logika interakcji dla klasy ErrorWindow.xaml
    /// </summary>
    public partial class ErrorWindow : Window
    {
        public ErrorWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

        }
    }
}
