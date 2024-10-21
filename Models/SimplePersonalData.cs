using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Contacts;

namespace EsercizioMVVM__RiccardoChen.Models
{
    public class SimplePersonalData
    {
        public static int CountID = 1;
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Data_Nascita { get; set; }
        public string Indirizzo { get; set; }
        public string Citta { get; set; }
        public int Cap { get; set; }
        public int Telefono { get; set; }

        public SimplePersonalData(){
            ID = CountID++;
            }
    }
}

    

