using RecipeApp.ViewModels;

namespace RecipeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
   }

}
