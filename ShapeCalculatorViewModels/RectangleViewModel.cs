using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.ShapeCalculatorViewModels
{
    internal class RectangleViewModel:INotifyPropertyChanged
    {
        private double _length;
        private double _width;
        private double _volumeheight;
        private double _volumelength;
        private double _volumewidth;

        public event PropertyChangedEventHandler PropertyChanged;
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
                OnPropertyChanged(nameof(Length));
            }
        }

        public double VolumeLength
        {
            get
            {
                return _volumelength;
            }
            set
            {
                _volumelength = value;
                OnPropertyChanged(nameof(VolumeLength));
            }
        }

        public double VolumeHeight
        {
            get
            {
                return _volumeheight;
            }
            set
            {
                _volumeheight = value;
                OnPropertyChanged(nameof(VolumeHeight));
            }
        }
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                OnPropertyChanged(nameof(Width));
            }
        }

        public double VolumeWidth
        {
            get
            {
                return _volumewidth;
            }
            set
            {
                _volumewidth = value;
                OnPropertyChanged(nameof(VolumeWidth));
            }
        }
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    } 
}
