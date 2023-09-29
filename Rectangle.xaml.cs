using ShapeCalculator.ShapeCalculatorViewModels;
using System.Collections.ObjectModel;

namespace ShapeCalculator;

public partial class Rectangle : ContentPage
{
	RectangleViewModel thisRectangle = new RectangleViewModel();
    private ObservableCollection<string> _units;
    private int _unitAreaPerimeterIdentifier = -1;
    private int _unitVolumeIdentifier = -1;

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

    public Rectangle()
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
        pickerAreaPerimeterUnit.SelectedIndex = 0;
        pickerVolumeUnit.SelectedIndex = 0;
    }

    private void pickerUnits_AreaSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
        if (selectedIndex == -1)
        {
            selectedIndex = 0;
        }
        _unitAreaPerimeterIdentifier = selectedIndex;
    }

    private void pickerUnits_PerimeterSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
        if (selectedIndex == -1)
        {
            selectedIndex = 0;
        }
        _unitAreaPerimeterIdentifier = selectedIndex;
    }

    private void pickerUnits_VolumeSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
        if (selectedIndex == -1)
        {
            selectedIndex = 0;
        }
        _unitVolumeIdentifier = selectedIndex;
    }

    private string CalculateRectanglePerimeter()
    {
        double length = 0;
        double width = 0;
        if (double.TryParse(txtRectangleLength.Text, out length))
        {
            thisRectangle.Length = Convert.ToDouble(txtRectangleLength.Text);
        }
        else
        {
            thisRectangle.Length = 0;
        }
        if (double.TryParse(txtRectangleWidth.Text, out width))
        {
            thisRectangle.Width = Convert.ToDouble(txtRectangleWidth.Text);
        }
        else
        {
            thisRectangle.Width = 0;
        }
        if (_unitAreaPerimeterIdentifier == 0)
        {
            return Convert.ToString("0");
        }
        else if (_unitAreaPerimeterIdentifier == 1)
        {
            return Math.Round(2 * thisRectangle.Length + 2 * thisRectangle.Width, 2).ToString() + " in";
        }
        else if (_unitAreaPerimeterIdentifier == 2)
        {
            return Math.Round(2 * thisRectangle.Length + 2 * thisRectangle.Width, 2).ToString() + " cm";
        }
        else if (_unitAreaPerimeterIdentifier == 3)
        {
            return Math.Round(2 * thisRectangle.Length + 2 * thisRectangle.Width, 2).ToString() + " m";
        }
        else if (_unitAreaPerimeterIdentifier == 4)
        {
            return Math.Round(2 * thisRectangle.Length + 2 * thisRectangle.Width, 2).ToString() + " km";
        }
        else
        {
            return Math.Round(2*thisRectangle.Length + 2*thisRectangle.Width, 2).ToString();
        }
    }

    private string CalculateRectangleVolume()
    {
        double width = 0;
        double length = 0;
        double height = 0;
        if (double.TryParse(txtRectangleVolumeLength.Text, out length))
        {
            thisRectangle.VolumeLength = Convert.ToDouble(txtRectangleVolumeLength.Text);
        }
        else
        {
            thisRectangle.VolumeLength = 0;
        }
        if (double.TryParse(txtRectangleVolumeHeight.Text, out height))
        {
            thisRectangle.VolumeHeight = Convert.ToDouble(txtRectangleVolumeHeight.Text);
        }
        else
        {
            thisRectangle.VolumeHeight = 0;
        }
        if (double.TryParse(txtRectangleVolumeWidth.Text, out width))
        {
            thisRectangle.VolumeWidth = Convert.ToDouble(txtRectangleVolumeWidth.Text);
        }
        else
        {
            thisRectangle.VolumeWidth = 0;
        }
        if (_unitVolumeIdentifier == 0)
        {
            return Convert.ToString("0");
        }
        else if (_unitVolumeIdentifier == 1)
        {
            return Math.Round(thisRectangle.VolumeLength * thisRectangle.VolumeWidth * thisRectangle.VolumeHeight, 2).ToString() + " in";
        }
        else if (_unitVolumeIdentifier == 2)
        {
            return Math.Round(thisRectangle.VolumeLength * thisRectangle.VolumeWidth * thisRectangle.VolumeHeight, 2).ToString() + " cm";
        }
        else if (_unitVolumeIdentifier == 3)
        {
            return Math.Round(thisRectangle.VolumeLength * thisRectangle.VolumeWidth * thisRectangle.VolumeHeight, 2).ToString() + " m";
        }
        else if (_unitVolumeIdentifier == 4)
        {
            return Math.Round(thisRectangle.VolumeLength * thisRectangle.VolumeWidth * thisRectangle.VolumeHeight, 2).ToString() + " km";
        }
        else
        {
            return Math.Round(thisRectangle.VolumeLength * thisRectangle.VolumeWidth * thisRectangle.VolumeHeight, 2).ToString();
        }

    }
    private string CalculateRectangleArea()
    {
        double length = 0;
        double width = 0;
        if (double.TryParse(txtRectangleLength.Text, out length))
        {
            thisRectangle.Length = Convert.ToDouble(txtRectangleLength.Text);
        }
        else
        {
            thisRectangle.Length = 0;
        }
        if (double.TryParse(txtRectangleWidth.Text, out width))
        {
            thisRectangle.Width = Convert.ToDouble(txtRectangleWidth.Text);
        }
        else
        {
            thisRectangle.Width = 0;
        }
        if (_unitAreaPerimeterIdentifier == 0)
        {
            return Convert.ToString("0");
        }
        else if (_unitAreaPerimeterIdentifier == 1)
        {
            return Math.Round(thisRectangle.Length * thisRectangle.Width, 2).ToString() + " in";
        }
        else if (_unitAreaPerimeterIdentifier == 2)
        {
            return Math.Round(thisRectangle.Length * thisRectangle.Width, 2).ToString() + " cm";
        }
        else if (_unitAreaPerimeterIdentifier == 3)
        {
            return Math.Round(thisRectangle.Length * thisRectangle.Width, 2).ToString() + " m";
        }
        else if (_unitAreaPerimeterIdentifier == 4)
        {
            return Math.Round(thisRectangle.Length * thisRectangle.Width, 2).ToString() + " km";
        }
        else
        {
            return Math.Round(thisRectangle.Length * thisRectangle.Width, 2).ToString();
        }

    }

    private void OnClearRectangleAreaPerimeterButtonClicked(object sender, EventArgs e)
    {
        txtRectangleLength.Text = String.Empty;
        txtRectangleWidth.Text = String.Empty;
        txtRectangleAreaResults.Text = String.Empty;
        txtRectanglePerimeterResults.Text = String.Empty;
    }

    private void OnClearRectangleVolumeButtonClicked(object sender, EventArgs e)
    {
        txtRectangleVolumeLength.Text = String.Empty;
        txtRectangleVolumeHeight.Text = String.Empty;
        txtRectangleVolumeWidth.Text = String.Empty;
        txtRectangleVolumeResults.Text = String.Empty;
    }


    private void OnCalculateRectangleAreaPerimeterButtonClicked(object sender, EventArgs e)
    {
        txtRectangleAreaResults.Text = CalculateRectangleArea();
        txtRectanglePerimeterResults.Text = CalculateRectanglePerimeter();
    }

    private void OnCalculateRectangleVolumeButtonClicked(object sender, EventArgs e)
    {
        txtRectangleVolumeResults.Text = CalculateRectangleVolume();
    }
}