using CadastroEvento.Models;
using System.Windows.Input;

namespace CadastroEvento.ViewModel;

public class CadastroEventoViewModel
{
    public class CadastroEventoViewModel
    {
        public Evento Evento { get; set; }

        public ICommand CadastrarCommand { get; }

        public CadastroEventoViewModel()
        {
            Evento = new Evento
            {
                DataInicio = DateTime.Now,
                DataTermino = DateTime.Now.AddDays(1)
            };

            CadastrarCommand = new Command(() =>
            {
                App.Current.MainPage.Navigation.PushAsync(new ResumoEventoViewModel());
            });
        }
    }
}
