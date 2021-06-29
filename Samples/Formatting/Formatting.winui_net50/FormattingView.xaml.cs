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

namespace Formatting
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FormattingView : Page
    {
        CultureInfo ci = new CultureInfo("en-US");
        bool IsPercentApplied = false;
        public FormattingView()
        {
            this.InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ci = new CultureInfo(e.AddedItems[0] as string);
            ChangeCulture(ci, "Culture");
        }

        private void ChangeCulture(CultureInfo ci, string control)
        {
            if (control == "Culture")
            {
                if (sfNumberBox_numberFormat.NumberFormatter is CurrencyFormatter)
                {
                    string currencySymbol = new RegionInfo(ci.LCID).ISOCurrencySymbol;
                    sfNumberBox_numberFormat.NumberFormatter = new CurrencyFormatter(currencySymbol, new string[] { ci.Name }, "ZZ");
                }
                else if (sfNumberBox_numberFormat.NumberFormatter is PercentFormatter)
                {
                    sfNumberBox_numberFormat.NumberFormatter = new PercentFormatter(new string[] { ci.Name }, "ZZ");
                }
                else
                {
                    sfNumberBox_numberFormat.NumberFormatter = new DecimalFormatter(new string[] { ci.Name }, "ZZ");
                }
            }
            else
            {
                if (IsPercentApplied)
                {
                    sfNumberBox_numberFormat.Value = sfNumberBox_numberFormat.Value * 100; IsPercentApplied = false;
                }

                if (control == "currency")
                {
                    string currencySymbol = new RegionInfo(ci.LCID).ISOCurrencySymbol;
                    sfNumberBox_numberFormat.NumberFormatter = new CurrencyFormatter(currencySymbol, new string[] { ci.Name }, "ZZ");
                }
                else if (control == "percentage")
                {
                    sfNumberBox_numberFormat.NumberFormatter = new PercentFormatter(new string[] { ci.Name }, "ZZ");
                    sfNumberBox_numberFormat.Value = sfNumberBox_numberFormat.Value / 100;
                    IsPercentApplied = true;
                }
                else
                {
                    sfNumberBox_numberFormat.NumberFormatter = new DecimalFormatter(new string[] { ci.Name }, "ZZ");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string control = (sender as Button).Tag.ToString();
            ChangeCulture(ci, control);
        }

        private void NumberBox_ValueChanged(NumberBox sender, NumberBoxValueChangedEventArgs args)
        {
            if (sfNumberBox_numberFormat.NumberFormatter is CurrencyFormatter)
            {
                (sfNumberBox_numberFormat.NumberFormatter as CurrencyFormatter).IntegerDigits = (int)args.NewValue;
            }
            else if (sfNumberBox_numberFormat.NumberFormatter is PercentFormatter)
            {
                (sfNumberBox_numberFormat.NumberFormatter as PercentFormatter).IntegerDigits = (int)args.NewValue;
            }
            else if (sfNumberBox_numberFormat.NumberFormatter is DecimalFormatter)
            {
                (sfNumberBox_numberFormat.NumberFormatter as DecimalFormatter).IntegerDigits = (int)args.NewValue;
            }
        }

        private void NumberBox_ValueChanged_1(NumberBox sender, NumberBoxValueChangedEventArgs args)
        {
            if (sfNumberBox_numberFormat.NumberFormatter is CurrencyFormatter)
            {
                (sfNumberBox_numberFormat.NumberFormatter as CurrencyFormatter).FractionDigits = (int)args.NewValue;
            }
            else if (sfNumberBox_numberFormat.NumberFormatter is PercentFormatter)
            {
                (sfNumberBox_numberFormat.NumberFormatter as PercentFormatter).FractionDigits = (int)args.NewValue;
            }
            else if (sfNumberBox_numberFormat.NumberFormatter is DecimalFormatter)
            {
                (sfNumberBox_numberFormat.NumberFormatter as DecimalFormatter).FractionDigits = (int)args.NewValue;
            }
        }
    } 
}
