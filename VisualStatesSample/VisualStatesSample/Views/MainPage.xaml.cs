using GalaSoft.MvvmLight.Command;
using VisualStatesSample.ViewModel;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace VisualStatesSample.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private EntityVM _entityVM;

        public MainPage()
        {
            this.InitializeComponent();
            _entityVM = new EntityVM();
            this.DataContext = _entityVM;
            _entityVM.ShowProductCommand = new RelayCommand(() => MenuSelectClick());
        }

        private void PageLoaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            _entityVM.GetAllEntities();
        }

        public void MenuSelectClick()
        {
            if (listProducts.Visibility == Windows.UI.Xaml.Visibility.Visible)
                listProducts.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            else
                listProducts.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }
    }
}
