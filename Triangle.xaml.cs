using System.ComponentModel;
using ShapeCalculator.ShapeCalculatorViewModels;
using System.Linq;
using System.Collections.ObjectModel;
namespace ShapeCalculator;

public partial class Triangle : ContentPage, INotifyPropertyChanged
{
	TriangleViewModel thisTriangle = new TriangleViewModel();
    private ObservableCollection<string> _units;
    private int _unitAreaIdentifier = -1;
    private int _unitPerimeterIdentifier = -1;
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

    public Triangle()
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
        pickerAreaUnit.SelectedIndex = 0;
        pickerPerimeterUnit.SelectedIndex = 0;
        pickerVolumeUnit.SelectedIndex = 0;
    }

    private void pickerUnits_AreaSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
        if(selectedIndex == -1)
        {
            selectedIndex = 0;
        }
        _unitAreaIdentifier = selectedIndex;
    }

    private void pickerUnits_PerimeterSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
        if(selectedIndex == -1)
        {
            selectedIndex = 0;
        }
        _unitPerimeterIdentifier = selectedIndex;
    }

    private void pickerUnits_VolumeSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
        if(selectedIndex == - 1)
        {
            selectedIndex = 0;
        }
        _unitVolumeIdentifier = selectedIndex;
    }

    private string CalculateTrianglePerimeter()
	{
		double side1 = 0;
		double side2 = 0;
		double side3 = 0;
		if(double.TryParse(txtTriangleSide1.Text, out side1))
		{
            thisTriangle.Side1 = Convert.ToDouble(txtTriangleSide1.Text);
        }
		else
		{
			thisTriangle.Side1 = 0;
		}
		if(double.TryParse(txtTriangleSide2.Text, out side2))
		{
            thisTriangle.Side2 = Convert.ToDouble(txtTriangleSide2.Text);
        }
		else
		{
			thisTriangle.Side2 = 0;
		}
		if(double.TryParse(txtTriangleSide3.Text, out side3))
		{
            thisTriangle.Side3 = Convert.ToDouble(txtTriangleSide3.Text);
        }
		else
		{
			thisTriangle.Side3 = 0;
		}
		if(_unitPerimeterIdentifier == 0)
        {
            return Convert.ToString("0");
        }
        else if(_unitPerimeterIdentifier == 1)
        {
            return Math.Round((thisTriangle.Side1 + thisTriangle.Side2 + thisTriangle.Side3), 2).ToString() + " in";
        }
        else if(_unitPerimeterIdentifier == 2)
        {
            return Math.Round((thisTriangle.Side1 + thisTriangle.Side2 + thisTriangle.Side3), 2).ToString() + " cm";
        }
        else if(_unitPerimeterIdentifier == 3)
        {
            return Math.Round((thisTriangle.Side1 + thisTriangle.Side2 + thisTriangle.Side3), 2).ToString() + " m";
        }
        else if(_unitPerimeterIdentifier == 4)
        {
            return Math.Round((thisTriangle.Side1 + thisTriangle.Side2 + thisTriangle.Side3), 2).ToString() + " km";
        }
        else
        {
            return Math.Round((thisTriangle.Side1 + thisTriangle.Side2 + thisTriangle.Side3), 2).ToString();
        }
	}

	private string CalculateTriangleVolume()
	{
		double baseRadius = 0;
		double height = 0;
		if(double.TryParse(txtTriangleVolumeBaseRadius.Text, out baseRadius))
		{
            thisTriangle.BaseRadius = Convert.ToDouble(txtTriangleVolumeBaseRadius.Text);
        }
		else
		{
			thisTriangle.BaseRadius = 0;
		}
		if (double.TryParse(txtTriangleVolumeHeight.Text, out height))
		{
            thisTriangle.Height = Convert.ToDouble(txtTriangleVolumeHeight.Text);
        }
		else
		{
			thisTriangle.Height = 0;
		}
		if(_unitVolumeIdentifier == 0)
        {
            return Convert.ToString("0");
        }
        else if(_unitVolumeIdentifier == 1)
        {
            return Math.Round((Math.PI * Math.Pow(thisTriangle.BaseRadius, 2) * thisTriangle.Height) / 3, 2).ToString() + " in";
        }
        else if(_unitVolumeIdentifier == 2)
        {
            return Math.Round((Math.PI * Math.Pow(thisTriangle.BaseRadius, 2) * thisTriangle.Height) / 3, 2).ToString() + " cm";
        }
        else if(_unitVolumeIdentifier == 3)
        {
            return Math.Round((Math.PI * Math.Pow(thisTriangle.BaseRadius, 2) * thisTriangle.Height) / 3, 2).ToString() + " m";
        }
        else if(_unitVolumeIdentifier == 4)
        {
            return Math.Round((Math.PI * Math.Pow(thisTriangle.BaseRadius, 2) * thisTriangle.Height) / 3, 2).ToString() + " km";
        }
        else
        {
            return Math.Round((Math.PI * Math.Pow(thisTriangle.BaseRadius, 2) * thisTriangle.Height) / 3, 2).ToString();
        }
  
    }
	private string CalculateTriangleArea() 
	{
		double bases = 0;
		double height = 0;
		if(double.TryParse(txtTriangleAreaBase.Text, out bases))
		{
            thisTriangle.Base = Convert.ToDouble(txtTriangleAreaBase.Text);
        }
		else
		{
			thisTriangle.Base = 0;
		}
		if(double.TryParse(txtTriangleAreaHeight.Text,out height))
		{
			thisTriangle.AreaHeight = Convert.ToDouble(txtTriangleAreaHeight.Text);
		}
		else
		{
			thisTriangle.AreaHeight = 0;
		}
		if(_unitAreaIdentifier == 0)
        {
            return Convert.ToString("0");
        }
        else if(_unitAreaIdentifier == 1)
        {
            return Math.Round(((thisTriangle.Base * thisTriangle.AreaHeight) / 2), 2).ToString() + " in";
        }
        else if(_unitAreaIdentifier == 2)
        {
            return Math.Round(((thisTriangle.Base * thisTriangle.AreaHeight) / 2), 2).ToString() + " cm";
        }
        else if(_unitAreaIdentifier == 3)
        {
            return Math.Round(((thisTriangle.Base * thisTriangle.AreaHeight) / 2), 2).ToString() + " m";
        }
        else if(_unitAreaIdentifier == 4)
        {
            return Math.Round(((thisTriangle.Base * thisTriangle.AreaHeight) / 2), 2).ToString() + " km";
        }
        else
        {
            return Math.Round(((thisTriangle.Base * thisTriangle.AreaHeight) / 2), 2).ToString();
        }

	}

	private void OnClearTriangleAreaButtonClicked(object sender, EventArgs e)
	{
		txtTriangleAreaBase.Text = String.Empty;
		txtTriangleAreaHeight.Text = String.Empty;
		txtTriangleAreaResults.Text = String.Empty;
	}

    private void OnClearTrianglePerimeterButtonClicked(object sender, EventArgs e)
    {
        txtTriangleSide1.Text = String.Empty;
        txtTriangleSide2.Text = String.Empty;
		txtTriangleSide3.Text = String.Empty;
		txtTrianglePerimeterResults.Text = String.Empty;
    }

    private void OnClearTriangleVolumeButtonClicked(object sender, EventArgs e)
    {
        txtTriangleVolumeBaseRadius.Text = String.Empty;
        txtTriangleVolumeHeight.Text = String.Empty;
		txtTriangleVolumeResults.Text = String.Empty;
    }


    private void OnCalculateTriangleAreaButtonClicked(object sender, EventArgs e)
    {
        txtTriangleAreaResults.Text = CalculateTriangleArea();
    }

    private void OnCalculateTriangleVolumeButtonClicked(object sender, EventArgs e)
    {
        txtTriangleVolumeResults.Text = CalculateTriangleVolume();
    }

    private void OnCalculateTrianglePerimeterButtonClicked(object sender, EventArgs e)
	{
		txtTrianglePerimeterResults.Text = CalculateTrianglePerimeter();
	}
}