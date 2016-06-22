using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace ControlLib
{
    public sealed class CarouselDemo : Control
    {
        public DataTemplate PrevNavigationContentTemplate
        {
            get { return (DataTemplate)GetValue(PrevNavigationContentTemplateProperty); }
            set { SetValue(PrevNavigationContentTemplateProperty, value); }
        }

        public DataTemplate NextNavigationContentTemplate
        {
            get { return GetValue(NextNavigationContentTemplateProperty) as DataTemplate; }
            set { SetValue(NextNavigationContentTemplateProperty, value); }
        }

        public static readonly DependencyProperty PrevNavigationContentTemplateProperty =
            DependencyProperty.Register(nameof(PrevNavigationContentTemplate),
                typeof(DataTemplate),
                typeof(CarouselDemo),
                new PropertyMetadata(null));

    
        public static readonly DependencyProperty NextNavigationContentTemplateProperty =
            DependencyProperty.Register(nameof(NextNavigationContentTemplate), 
                typeof(DataTemplate), 
                typeof(CarouselDemo), 
                new PropertyMetadata(null));


        public CarouselDemo()
        {
            this.DefaultStyleKey = typeof(CarouselDemo);
        }
    }
}
