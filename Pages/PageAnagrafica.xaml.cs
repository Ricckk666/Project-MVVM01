using EsercizioMVVM__RiccardoChen.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace EsercizioMVVM__RiccardoChen.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageAnagrafica : Page
    {
        PersonalDataViewModel dataViewModel = new();
        public PageAnagrafica()
        {
            this.InitializeComponent();
            DataContext = dataViewModel;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SimplePersonalData persona = dataViewModel.SimplePersonal;

            string nome = persona.Nome;
            string cognome = persona.Cognome;


            if(string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cognome)) {


                MessaggioErr.Text = "Nome o Cognome non inserito";

            }
            else
            {
                dataViewModel.SimplePersonalDatas.Add(dataViewModel.SimplePersonal);
                dataViewModel.SimplePersonal = new SimplePersonalData();
            }
 
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            SimplePersonalData.CountID = 1;
            Frame.Navigate(typeof(PaginaLog));
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void DataNascita_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
