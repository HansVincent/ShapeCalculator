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
        private double _edge1;
        private double _edge2;
        private double _edge3;
        private double _side1;
        private double _side2;
        private double _side3;
        private double _baseradius;
        private double _height;

        public event PropertyChangedEventHandler PropertyChanged;
        public double Edge1
        {
            get
            {
                return _edge1;
            }
            set
            {
                _edge1 = value;
                OnPropertyChanged(nameof(Edge1));
            }
        }

        public double Edge2
        {
            get
            {
                return _edge2;
            }
            set
            {
                _edge2 = value;
                OnPropertyChanged(nameof(Edge2));
            }
        }

        public double Edge3
        {
            get
            {
                return _edge3;
            }
            set
            {
                _edge3 = value;
                OnPropertyChanged(nameof(Edge3));
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
