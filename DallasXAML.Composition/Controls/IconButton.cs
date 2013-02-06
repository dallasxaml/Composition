using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DallasXAML.Composition.Controls
{
    public class IconButton : Button
    {
        public static DependencyProperty IconProperty =
            DependencyProperty.Register(
                "Icon",
                typeof(FrameworkElement),
                typeof(IconButton));

        static IconButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(IconButton),
                new FrameworkPropertyMetadata(typeof(IconButton)));
        }

        public FrameworkElement Icon
        {
            get { return (FrameworkElement)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
    }
}
