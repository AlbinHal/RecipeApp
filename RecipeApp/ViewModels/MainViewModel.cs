using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using RecipeApp.Models;
using CommunityToolkit.Mvvm.Input;
using RecipeApp.Views;

namespace RecipeApp.ViewModels;
public partial class MainViewModel : ObservableObject
{

    public MainViewModel()
    {
        Recipes = new ObservableCollection<Recipe>
        {
            new Recipe{Name="Gin Tonic",
                Minutes="1",
                Ingredients = new List<string>
                {"Gin", "Tonic"},
                Image = "gintonic.png" },
            new Recipe{Name="Irish Coffee",
                Minutes="10",
                Ingredients = new List<string>()
                {
                    "Kaffe", "Gradde", "Whiskey"
                },
                Image = "irishcoffee.png"},
            new Recipe{Name="Pajala Sunrise",
                Minutes="1",
                Ingredients = new List<string>
                {"Vodka", "Falukorv"},
                Image = "pajalasunrise.png"}
        };

    }

    [ObservableProperty]
    private ObservableCollection<Recipe> recipes;

    [RelayCommand]
    void AddRecipe(Recipe r)
    {
        if (r == null)
            return;
        Recipes.Add(r);
    }

    [RelayCommand]
    async Task Tap(Recipe r)
    {
        var navigationcontext = new Dictionary<string, object>
        {
            {"Recipe", r }
        };
        await Shell.Current.GoToAsync(nameof(DetailsPage), true, navigationcontext);
    }

}
