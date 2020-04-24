using System;
using System.ComponentModel;

namespace DataFormXamariniOS
{
    public class DataFormModel : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Address { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}