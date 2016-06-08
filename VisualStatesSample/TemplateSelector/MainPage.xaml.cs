using TemplateSelector.ViewModel;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TemplateSelector
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainPageVM _entityVM;

        public MainPage()
        {
            this.InitializeComponent();
            _entityVM = new MainPageVM();
            _entityVM.GetAllEntities();
            this.DataContext = _entityVM;
        }

        private void PageLoaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
           
        }
    }
}
