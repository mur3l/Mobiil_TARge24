using ScientificCalculator.ViewModels;

namespace ScientificCalculator.Views;

public partial class CalculatorPage : ContentPage
{
	public CalculatorPage()
	{
		InitializeComponent();

		this.BindingContext = new CalculatorPageViewModel();
    }
}