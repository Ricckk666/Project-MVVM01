using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioMVVM__RiccardoChen.Models

{
    internal class PersonalDataViewModel: INotifyPropertyChanged
    {
        SimplePersonalData personalData = new();
        public ObservableCollection<SimplePersonalData> SimplePersonalDatas { get; set; } = new ObservableCollection<SimplePersonalData>();

        public SimplePersonalData SimplePersonal
        {
            get => personalData;
            set
            {
                personalData = value;
                OnPropertyChanged(nameof(ID));
                OnPropertyChanged(nameof(Nome));
                OnPropertyChanged(nameof(Cognome));
                OnPropertyChanged(nameof(DataNascita));
                OnPropertyChanged(nameof(Indirizzo));
                OnPropertyChanged(nameof(Citta));
                OnPropertyChanged(nameof(CAP));
                OnPropertyChanged(nameof(NumTelefono));

            }
        }
        public int ID
        {
            get => personalData.ID;
            set
            {
                personalData.ID = value;
                OnPropertyChanged(nameof(ID));
            }
        }

        public string Nome
        {
            get => personalData.Nome;
            set
            {
                personalData.Nome = value;
                OnPropertyChanged(nameof(Nome));
            }
        }
        public string Cognome
        {
            get => personalData.Cognome;
            set
            {
                personalData.Cognome = value;
                OnPropertyChanged(nameof(Cognome));
            }
        }
        public string DataNascita
        {
            get => personalData.Data_Nascita;
            set
            {
                personalData.Data_Nascita = value;
                OnPropertyChanged(nameof(DataNascita));
            }
        }
        public string Indirizzo
        {
            get => personalData.Indirizzo;
            set
            {
                personalData.Indirizzo = value;
                OnPropertyChanged(nameof(Indirizzo));
            }
        }
        public string Citta
        {
            get => personalData.Citta;
            set
            {
                personalData.Citta = value;
                OnPropertyChanged(nameof(Citta));
            }
        }
        public int CAP
        {
            get => personalData.Cap;
            set
            {
                personalData.Cap = value;
                OnPropertyChanged(nameof(CAP));
            }
        }
        public int NumTelefono
        {
            get => personalData.Telefono;
            set
            {
                personalData.Telefono = value;
                OnPropertyChanged(nameof(NumTelefono));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }
}
