using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Syncfusion.UI.Xaml.Core;
using Syncfusion.UI.Xaml.Editors;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization;
using Windows.Globalization.NumberFormatting;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ExploringNumberBox
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NumberBoxView : Page
    {
        public NumberBoxView()
        {
            this.InitializeComponent();
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            //NumberFormatter
            pageNumberBox1.NumberFormatter = new DecimalFormatter()
            {                
                FractionDigits = 0,
                NumberRounder = new IncrementNumberRounder() 
                {                    
                    RoundingAlgorithm= RoundingAlgorithm.RoundDown 
                }
            };
            priceNumberBox1.NumberFormatter = new CurrencyFormatter("USD")
            {
                FractionDigits = 3,
                NumberRounder = new IncrementNumberRounder() { Increment = 0.0001 }
            };
            courseNumberBox1.NumberFormatter = new PercentFormatter()
            {
                IntegerDigits = 3,
                FractionDigits = 2,
                NumberRounder = new IncrementNumberRounder() { Increment = 0.01 }
            };

            //CustomFormat
            pageNumberBox2.CustomFormat = "#";
            priceNumberBox2.CustomFormat = "$#0.000#";
            courseNumberBox2.CustomFormat = "#000.00%";
        }
    }
}
