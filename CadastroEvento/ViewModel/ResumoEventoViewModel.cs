using CadastroEvento.Models;

namespace CadastroEvento.ViewModel;

public class ResumoEventoViewModel
{
    public class ResumoEventoViewModel
    {
        public Evento Evento { get; }

        public ResumoEventoViewModel(Evento evento)
        {
            Evento = evento;
        }
    }
}