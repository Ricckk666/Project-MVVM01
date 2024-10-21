using EsercizioMVVM__RiccardoChen.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PaginaRegistrazione : Page
    {
        public PaginaRegistrazione()
        {
            this.InitializeComponent();
        }

        private void Registrazione_Click(object sender, RoutedEventArgs e)
        {
            Credenziali userInfo = new Credenziali();    
            userInfo.Username = Username.Text ;
            userInfo.Password = EncryptPassword(Password.Password);

            Messaggio.Text = SalvaInfo(userInfo);

            Frame.Navigate(typeof(PageAnagrafica));


        }

        private string EncryptPassword(string password)
        {
            string encryptedpwd = string.Empty;

            SHA256 sHA256 = SHA256.Create();
            
            byte[] bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(password));
            
            for (int i = 0; i < bytes.Length; i++)
            {
                encryptedpwd += bytes[i].ToString("X2");
                
            }

            return encryptedpwd;
            
        }

        private string SalvaInfo(Credenziali userInfo)
        {
            try
            {

                StorageFile file = ApplicationData.Current.LocalFolder.GetFileAsync("credentials.json").GetAwaiter().GetResult();

            }
            catch (Exception e)
            {
                StorageFile file = ApplicationData.Current.LocalFolder.CreateFileAsync("credentials.json",
                     CreationCollisionOption.ReplaceExisting).GetAwaiter().GetResult();

                string jsonContent = JsonConvert.SerializeObject(userInfo);
                FileIO.WriteTextAsync(file, jsonContent).GetAwaiter().GetResult();

                return e.Message + " Dati non salvati bene";
              

            }
            return "Dati salvati con successo!";


        }



        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PaginaLog));
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
