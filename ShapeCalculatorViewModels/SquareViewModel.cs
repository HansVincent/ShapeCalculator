using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.ShapeCalculatorViewModels
{
    internal class SquareViewModel : INotifyPropertyChanged
    {
        private int _side;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Side
        {
            get
            {
                return _side;
            }
            set
            {
                _side = value;
                OnPropertyChanged(nameof(Side));
            }
        }
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
