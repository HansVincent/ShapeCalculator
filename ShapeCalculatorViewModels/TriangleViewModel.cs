using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ShapeCalculator.ShapeCalculatorViewModels;

namespace ShapeCalculator.ShapeCalculatorViewModels
{
    internal class TriangleViewModel: INotifyPropertyChanged
    {
        private double _base;
        private double _areaheight;
        private double _side1;
        private double _side2;
        private double _side3;
        private double _baseradius;
        private double _height;

        public event PropertyChangedEventHandler PropertyChanged;
        public double Base
        {
            get
            {
                return _base;
            }
            set
            {
                _base = value;
                OnPropertyChanged(nameof(Base));
            }
        }

        public double AreaHeight
        {
            get
            {
                return _areaheight;
            }
            set
            {
                _areaheight = value;
                OnPropertyChanged(nameof(AreaHeight));
            }
        }
        public double Side1
        {
            get
            {
                return _side1;
            }
            set
            {
                _side1 = value;
                OnPropertyChanged(nameof(Side1));
            }
        }

        public double Side2
        {
            get
            {
                return _side2;
            }
            set
            {
                _side2 = value;
                OnPropertyChanged(nameof(Side2));
            }
        }

        public double Side3
        {
            get
            {
                return _side3;
            }
            set
            {
                _side3 = value;
                OnPropertyChanged(nameof(Side3));
            }
        }

        public double BaseRadius
        {
            get
            {
                return _baseradius;
            }
            set
            {
                _baseradius = value;
                OnPropertyChanged(nameof(BaseRadius));
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                OnPropertyChanged(nameof(Height));
            }
        }
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
