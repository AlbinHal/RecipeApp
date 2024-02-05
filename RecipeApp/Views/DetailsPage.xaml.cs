using RecipeApp.ViewModels;

namespace RecipeApp.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}