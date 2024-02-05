using CommunityToolkit.Mvvm.ComponentModel;
using RecipeApp.Models;
namespace RecipeApp.ViewModels;
[QueryProperty(nameof(Recipe), "Recipe")]
public partial class DetailViewModel : ObservableObject
{
    public DetailViewModel()
    {

    }
    [ObservableProperty]
    Recipe recipe;
}

