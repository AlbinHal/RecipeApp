using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace RecipeApp.Models;
public class Recipe 
{
    public string Name { get; set; }
    public string Minutes { get; set; }
    public List<string> Ingredients { get; set; }
    public string Image { get; set; }
}
