
using CadastroEventosMaui.Models;
using CadastroEventosMaui.ViewModels;
using System.Globalization;

namespace CadastroEventosMaui.Views;

public partial class CadastroEventoPage : ContentPage
{
    public CadastroEventoPage()
    {
        InitializeComponent();

        BindingContext = new EventoViewModel();
    }

    private async void Cadastrar_Clicked(object sender, EventArgs e)
    {
        var viewModel = (EventoViewModel)BindingContext;
        Evento evento = viewModel.Evento;

        if (string.IsNullOrWhiteSpace(evento.Nome))
        {
            await DisplayAlert("Atenção",
                "Informe o nome do evento.", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(evento.Local))
        {
            await DisplayAlert("Atenção",
                "Informe o local do evento.", "OK");
            return;
        }

        if (evento.NumeroParticipantes <= 0)
        {
            await DisplayAlert("Atenção",
                "Informe a quantidade de participantes.", "OK");
            return;
        }

        if (evento.CustoPorParticipante < 0)
        {
            await DisplayAlert("Atenção",
                "Informe um custo válido.", "OK");
            return;
        }

        if (evento.DataTermino.Date < evento.DataInicio.Date)
        {
            await DisplayAlert("Atenção",
                "A data de término não pode ser anterior à data de início.",
                "OK");
            return;
        }

        await Navigation.PushAsync(new ResumoEventoPage
        {
            BindingContext = evento
        });
    }
}
