
using CadastroEventosMaui.Models;

namespace CadastroEventosMaui.ViewModels;

public class EventoViewModel
{
    public Evento Evento { get; set; }

    public EventoViewModel()
    {
        Evento = new Evento();
    }
}
