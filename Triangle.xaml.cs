using System.ComponentModel;
using ShapeCalculator.ShapeCalculatorViewModels;
namespace ShapeCalculator;

public partial class Triangle : ContentPage, INotifyPropertyChanged
{
	TriangleViewModel thisTriangle = new TriangleViewModel();
	BaseParameters triangleParameters = new BaseParameters();

	public Triangle()
	{
		InitializeComponent();
	}

	private string CalculateTrianglePerimeter()
	{
		thisTriangle.Side1 = Convert.ToDouble(txtTriangleSide1.Text);
		thisTriangle.Side2 = Convert.ToDouble(txtTriangleSide2.Text);
		thisTriangle.Side3 = Convert.ToDouble(txtTriangleSide3.Text);
		return (thisTriangle.Side1 + thisTriangle.Side2 + thisTriangle.Side3).ToString();
	}

	private void OnCalculatePerimeterButtonClicked(object sender, EventArgs e)
	{
		txtTrianglePerimeterResults.Text = CalculateTrianglePerimeter();
	}
}