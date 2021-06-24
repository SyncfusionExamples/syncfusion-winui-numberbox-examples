using Syncfusion.UI.Xaml.Core;
using Syncfusion.UI.Xaml.Editors;
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

namespace ExploringNumberBox
{
    public class NumberBoxViewModel : NotificationObject
    {
        private string course;
        public string CourseName
        {
            get { return course; }
            set
            {
                course = value;
                RaisePropertyChanged(nameof(CourseName));
            }
        }

        private double completion;
        public double CourseCompletion
        {
            get { return completion; }
            set
            {
                completion = value;
                RaisePropertyChanged(nameof(CourseCompletion));
            }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
                RaisePropertyChanged(nameof(Price));
            }
        }

        private double numberOfPages;
        public double NumberOfPages
        {
            get { return numberOfPages; }
            set
            {
                numberOfPages = value;
                RaisePropertyChanged(nameof(NumberOfPages));
            }
        }

        private string placeholderText = "Enter Fahrenheit value";
        public string PlaceholderText
        {
            get
            {
                return placeholderText;
            }
            set
            {
                placeholderText = value;
                this.RaisePropertyChanged(nameof(this.PlaceholderText));
            }
        }

        private double? fahrenheitValue = null;
        public double? FahrenheitValue
        {
            get
            {
                return fahrenheitValue;
            }
            set
            {
                fahrenheitValue = value;
                this.RaisePropertyChanged(nameof(this.FahrenheitValue));
            }
        }

        private bool allowNull = true;
        public bool AllowNull
        {
            get
            {
                return allowNull;
            }
            set
            {
                allowNull = value;
                this.RaisePropertyChanged(nameof(this.AllowNull));
            }
        }

        private bool isEditable = true;
        public bool IsEditable
        {
            get
            {
                return isEditable;
            }
            set
            {
                isEditable = value;
                this.RaisePropertyChanged(nameof(this.IsEditable));
            }
        }

        private double minimum = -100;
        public double Minimum
        {
            get
            {
                return minimum;
            }
            set
            {
                minimum = value;
                this.RaisePropertyChanged(nameof(this.Minimum));
            }
        }

        private double maximum = 1000;
        public double Maximum
        {
            get
            {
                return maximum;
            }
            set
            {
                maximum = value;
                this.RaisePropertyChanged(nameof(this.Maximum));
            }
        }

        private double smallChange = 10.0;
        public double SmallChange
        {
            get
            {
                return smallChange;
            }
            set
            {
                smallChange = value;
                this.RaisePropertyChanged(nameof(this.SmallChange));
            }
        }

        private double largeChange = 100.0;
        public double LargeChange
        {
            get
            {
                return largeChange;
            }
            set
            {
                largeChange = value;
                this.RaisePropertyChanged(nameof(this.LargeChange));
            }
        }

        private NumberBoxUpDownPlacementMode upDownPlacementMode = NumberBoxUpDownPlacementMode.Inline;
        public NumberBoxUpDownPlacementMode UpDownPlacementMode
        {
            get
            {
                return upDownPlacementMode;
            }
            set
            {
                upDownPlacementMode = value;
                this.RaisePropertyChanged(nameof(this.UpDownPlacementMode));
            }
        }
    }
}
