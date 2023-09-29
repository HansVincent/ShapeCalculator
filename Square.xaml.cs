using ShapeCalculator.ShapeCalculatorViewModels;
using System.Collections.ObjectModel;

namespace ShapeCalculator;

public partial class Square : ContentPage
{
    SquareViewModel thisSquare = new SquareViewModel();
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

    public Square()
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

    private string CalculateSquarePerimeter()
    {
        int side = 0;
        if (int.TryParse(txtSquareSide.Text, out side))
        {
            thisSquare.Side = Convert.ToInt32(txtSquareSide.Text);
        }
        else
        {
            thisSquare.Side = 0;
        }
        if (_unitAreaPerimeterVolumeIdentifier == 0)
        {
            return Convert.ToString("0");
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 1)
        {
            return (4 * thisSquare.Side).ToString() + " in";
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 2)
        {
            return (4 * thisSquare.Side).ToString() + " cm";
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 3)
        {
            return (4 * thisSquare.Side).ToString() + " m";
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 4)
        {
            return (4 * thisSquare.Side).ToString() + " km";
        }
        else
        {
            return (4 * thisSquare.Side).ToString();
        }
    }

    private string CalculateSquareVolume()
    {
        int side = 0;
        if (int.TryParse(txtSquareSide.Text, out side))
        {
            thisSquare.Side = Convert.ToInt32(txtSquareSide.Text);
        }
        else
        {
            thisSquare.Side = 0;
        }
        if (_unitAreaPerimeterVolumeIdentifier == 0)
        {
            return Convert.ToString("0");
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 1)
        {
            return Math.Pow(thisSquare.Side, 3).ToString() + " in";
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 2)
        {
            return Math.Pow(thisSquare.Side, 3).ToString() + " cm";
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 3)
        {
            return Math.Pow(thisSquare.Side, 3).ToString() + " m";
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 4)
        {
            return Math.Pow(thisSquare.Side, 3).ToString() + " km";
        }
        else
        {
            return Math.Pow(thisSquare.Side, 3).ToString();
        }
    }
    private string CalculateSquareArea()
    {
        int side = 0;
        if (int.TryParse(txtSquareSide.Text, out side))
        {
            thisSquare.Side = Convert.ToInt32(txtSquareSide.Text);
        }
        else
        {
            thisSquare.Side = 0;
        }
        if (_unitAreaPerimeterVolumeIdentifier == 0)
        {
            return Convert.ToString("0");
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 1)
        {
            return Math.Pow(thisSquare.Side, 2).ToString() + " in";
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 2)
        {
            return Math.Pow(thisSquare.Side, 2).ToString() + " cm";
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 3)
        {
            return Math.Pow(thisSquare.Side, 2).ToString() + " m";
        }
        else if (_unitAreaPerimeterVolumeIdentifier == 4)
        {
            return Math.Pow(thisSquare.Side, 2).ToString() + " km";
        }
        else
        {
            return Math.Pow(thisSquare.Side, 2).ToString();
        }
    }

    private void OnClearSquareAreaPerimeterVolumeButtonClicked(object sender, EventArgs e)
    {
        txtSquareSide.Text = String.Empty;
    }



    private void OnCalculateSquareAreaPerimeterVolumeButtonClicked(object sender, EventArgs e)
    {
        txtSquareAreaResults.Text = CalculateSquareArea();
        txtSquarePerimeterResults.Text = CalculateSquarePerimeter();
        txtSquareCubeResults.Text = CalculateSquareVolume();
    }
}