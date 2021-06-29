using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatting
{
    class FormattingViewModel : INotifyPropertyChanged
    {
        private bool isEditable;
        private bool allowNull;
        public event PropertyChangedEventHandler PropertyChanged;
        public bool IsEditable
        {
            get { return isEditable; }
            set { isEditable = value;
                OnRaisePropertyChanged(nameof(IsEditable));
            }
        }

        public bool AllowNull
        {
            get { return allowNull; }
            set { allowNull = value;
                OnRaisePropertyChanged(nameof(AllowNull));
            }
        }
        internal void OnRaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }

        public FormattingViewModel()
        {
            this.IsEditable = this.AllowNull = true;
        }
        
    }
}
