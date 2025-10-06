using MauiGRUD.ViewModels;

namespace MauiGRUD
{
    public partial class MainPage : ContentPage
    {
        private readonly ProductsViewModel _productsViewModel;
        public MainPage
            (
                ProductsViewModel productsViewModel
            )
        {
            InitializeComponent();
            BindingContext = productsViewModel;
            _productsViewModel = productsViewModel;
        }
        protected async void OnAppearing()
        { 
            base.OnAppearing();
            await _productsViewModel.LoadProductsAsync();
        }
            
        
    }
}
