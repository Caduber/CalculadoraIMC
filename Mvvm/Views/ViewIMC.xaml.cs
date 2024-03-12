using ProjetoComercial.Mvvm.ViewModels;

namespace ProjetoComercial.Mvvm.Views;

public partial class ViewIMC : ContentPage
{
	public ViewIMC()
	{
		InitializeComponent();
		BindingContext = new ImcViewModel();
	}
}