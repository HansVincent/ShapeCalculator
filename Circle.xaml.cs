using ShapeCalculator.ShapeCalculatorViewModels;
using System.Collections.ObjectModel;

namespace ShapeCalculator;

public partial class Circle : ContentPage
{
    CircleViewModel thisCircle = new CircleViewModel();
    private ObservableCollection<string> _units;
    private int _unitAreaPerimeterVolumeIdentifier = -1;
    public ObservableCollection<string> Units
    {
        get
        {
            return _units;
        }
        set
        {
            _units = value;
            OnPropertyChanged(nameof(Units));
        }
    }

    public Circle()
    {
        InitializeComponent();
        Units = new ObservableCollection<string>
        {
            "=Select=",
            "Inches",
            "Centimeters",
            "Meters",
            "Kilometers"
        };
        BindingContext = this;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        pickerAreaPerimeterVolumeUnit.SelectedIndex = 0;
    }

    private void pickerUnits_AreaPerimeterVolumeSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
        if (selectedIndex == -1)
        {
            selectedIndex = 0;
        }
        _unitAreaPerimeterVolumeIdentifier = selectedIndex;
    }

    private string CalculateCirclePerimeter()
    {
        double radius = 0;
        if (double.TryParse(txtCircleRadius.Text, out radius))
        {
            thisCircle.Radius = Convert.ToDouble(txtCircleRadius.Text);
        }
        else
        {
            thisCircle.Radius = 0;
        }
        if (_unitAreaPerimeterVolumeIdentifier == 0)
        {
            return Convert.ToString("0");
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 1)
        {
            return (2 * thisCircle.Radius).ToString() + " in";
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 2)
        {
            return (2 * thisCircle.Radius).ToString() + " cm";
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 3)
        {
            return (2 * thisCircle.Radius).ToString() + " m";
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 4)
        {
            return (2 * thisCircle.Radius).ToString() + " km";
        }
        else
        {
            return (2 * thisCircle.Radius).ToString();
        }
    }

    private string CalculateCircleSphere()
    {
        double radius = 0;
        if (double.TryParse(txtCircleRadius.Text, out radius))
        {
            thisCircle.Radius = Convert.ToInt32(txtCircleRadius.Text);
        }
        else
        {
            thisCircle.Radius = 0;
        }
        if (_unitAreaPerimeterVolumeIdentifier == 0)
        {
            return Convert.ToString("0");
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 1)
        {
            return Math.Round((Math.Pow(thisCircle.Radius, 3) * (Math.PI) * 4) / 3).ToString() + " in";
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 2)
        {
            return Math.Round((Math.Pow(thisCircle.Radius, 3) * (Math.PI) * 4) / 3).ToString() + " cm";
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 3)
        {
            return Math.Round((Math.Pow(thisCircle.Radius, 3) * (Math.PI) * 4) / 3).ToString() + " m";
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 4)
        {
            return Math.Round((Math.Pow(thisCircle.Radius, 3) * (Math.PI) * 4) / 3).ToString() + " km";
        }
        else
        {
            return Math.Round((Math.Pow(thisCircle.Radius, 3) * (Math.PI) * 4) / 3).ToString();
        }
    }   

        private string CalculateCircleArea()
        {
            double radius = 0;
            if(double.TryParse(txtCircleRadius.Text, out radius))
            {
                thisCircle.Radius = Convert.ToInt32(txtCircleRadius.Text);
            }
            else
            {
                thisCircle.Radius = 0;
            }
            if(_unitAreaPerimeterVolumeIdentifier == 0)
            {
                return Convert.ToString("0");
            }
            else if(_unitAreaPerimeterVolumeIdentifier == 1)
            {
                return Math.Round((Math.PI * Math.Pow(thisCircle.Radius, 2)), 2).ToString() + " in";
            }
            else if(_unitAreaPerimeterVolumeIdentifier == 2)
            {
                return Math.Round((Math.PI * Math.Pow(thisCircle.Radius, 2)), 2).ToString() + " cm";
            }
            else if(_unitAreaPerimeterVolumeIdentifier == 3)
            {
                return Math.Round((Math.PI * Math.Pow(thisCircle.Radius, 2)), 2).ToString() + " m";
            }
            else if(_unitAreaPerimeterVolumeIdentifier == 4)
            {
                return Math.Round((Math.PI * Math.Pow(thisCircle.Radius, 2)), 2).ToString() + " km";
            }
            else
            {
                return Math.Round((Math.PI * Math.Pow(thisCircle.Radius, 2)), 2).ToString();
            }
        }

        private void OnClearCircleAreaPerimeterVolumeButtonClicked(object sender, EventArgs e)
        {
            txtCircleRadius.Text = String.Empty;
        }



        private void OnCalculateCircleAreaPerimeterVolumeButtonClicked(object sender, EventArgs e)
        {
            txtCircleAreaResults.Text = CalculateCircleArea();
            txtCirclePerimeterResults.Text = CalculateCirclePerimeter();
            txtCircleSphereResults.Text = CalculateCircleSphere();
        }
}
