
namespace CadastroEventosMaui.Views;

public partial class ResumoEventoPage : ContentPage
{
    public ResumoEventoPage()
    {
        InitializeComponent();
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
