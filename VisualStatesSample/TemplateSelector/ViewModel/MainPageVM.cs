using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using TemplateSelector.Model;

namespace TemplateSelector.ViewModel
{
    public class MainPageVM : ViewModelBase, INotifyPropertyChanged
    {
        private ObservableCollection<Entity> _entities;
        private ICommand _productDetails;
        public ObservableCollection<Entity> Entities
        {
            get { return _entities; }
            set
            {
                _entities = value;
                OnPropertyChanged("Entities");
            }
        }

        public string Description { get; set; }
        public int ID { get; set; }
        public string Image { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ShowProductCommand
        {
            get { return _productDetails; }
            set
            {
                _productDetails = value;
                OnPropertyChanged("ShowProductCommand");
            }
        }

        public MainPageVM()
        {
            Entities = new ObservableCollection<Entity>();
        }


        public void GetAllEntities()
        {
            Entities = Service.Service.GetAllEntities();
        }

        public void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
