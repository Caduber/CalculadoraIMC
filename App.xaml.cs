using ProjetoComercial.Mvvm.Views;

namespace ProjetoComercial;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new ViewIMC());
    }
}
