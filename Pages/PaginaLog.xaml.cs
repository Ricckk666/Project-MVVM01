using EsercizioMVVM__RiccardoChen.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
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
    
    public sealed partial class PaginaLog : Page
    {
        public PaginaLog()
        {
            this.InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {

            string userName = Username.Text ;
            string password = Password.Password ;

            if (password.ToLower().Equals("admin") && userName.ToLower().Equals("admin"))
            {
                Frame.Navigate(typeof(PageAnagrafica));

            }
            else
            {
                ErrorMessage.Text = "Username o Password scorretta, riprova";
                Username.Text = "";
                Password.Password = "";

            }

        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PaginaRegistrazione));

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        /*private bool RegisterNewUser()
        {
            bool 
        }

        private bool CheckCredenziali()
        {
            bool result = false;
            Credenziali credenziali = new();
            {
                Username = Username.Text;
                Password = Password.Password;
            };

            StorageFile file = Application.Current.
            return result;
        }*/
    }
}
