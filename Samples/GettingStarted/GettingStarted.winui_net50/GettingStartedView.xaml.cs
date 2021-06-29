using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization.NumberFormatting;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GettingStarted
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GettingStartedView : Page
    {
        public GettingStartedView()
        {
            this.InitializeComponent();
        }

        private void sfNumberBox_ValueChanged(object sender, Syncfusion.UI.Xaml.Editors.ValueChangedEventArgs e)
        {
            var oldValue = e.OldValue;
            var newValue = e.NewValue;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo culture = new CultureInfo("fr-FR");
            string currencySymbol = new RegionInfo(culture.LCID).ISOCurrencySymbol;
            sfNumberBox.NumberFormatter = new CurrencyFormatter(currencySymbol);
        }
    }
}
