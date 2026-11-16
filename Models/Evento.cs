
namespace CadastroEventosMaui.Models;

public class Evento
{
    public string Nome { get; set; } = "";

    public DateTime DataInicio { get; set; } = DateTime.Today;

    public DateTime DataTermino { get; set; } = DateTime.Today;

    public int NumeroParticipantes { get; set; }

    public string Local { get; set; } = "";

    public decimal CustoPorParticipante { get; set; }

    // Calcula a diferença entre as datas
    public TimeSpan Duracao
    {
        get
        {
            return DataTermino.Date - DataInicio.Date;
        }
    }

    // Retorna a duração em dias
    public int DuracaoEmDias
    {
        get
        {
            return Duracao.Days;
        }
    }

    // Calcula o custo total
    public decimal CustoTotal
    {
        get
        {
            return NumeroParticipantes * CustoPorParticipante;
        }
    }
}
