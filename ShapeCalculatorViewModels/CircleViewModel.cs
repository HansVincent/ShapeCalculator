using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.ShapeCalculatorViewModels
{
    internal class CircleViewModel : INotifyPropertyChanged
    {
        private double _radius;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
                OnPropertyChanged(nameof(Radius));
            }
        }
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
