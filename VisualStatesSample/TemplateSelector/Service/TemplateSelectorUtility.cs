using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TemplateSelector.Service
{
    public class TemplateSelectorUtility: DataTemplateSelector
    {
        public DataTemplate FirstDataTemplate { get; set; }
        public DataTemplate SecondDataTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            var itemsControl = ItemsControl.ItemsControlFromItemContainer(container);
            if (itemsControl.IndexFromContainer(container) > 5)
            {
                return SecondDataTemplate;
            }
            return FirstDataTemplate;
        }
    }
}
