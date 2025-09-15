using ScientificCalculator.ViewModels;

namespace ScientificCalculator.Views;

public partial class CalculatorPage : ContentPage
{
	public CalculatorPage()
	{
		InitializeComponent();

		this.BindingContext = new CalculatorPageViewModel();
    }

    public static implicit operator Page(CalculatorPage v)
    {
        throw new NotImplementedException();
    }
}