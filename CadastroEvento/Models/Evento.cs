using System;
using System.ComponentModel;

namespace CadastroEvento.Models;

public class Evento : INotifyPropertyChanged
{
    public Evento()
    { } 

    private DateTime _dataInicio;
    private DateTime _dataTermino;
    private int _numeroParticipantes;
    private decimal _custoPorParticipante;

    public string Nome { get; set; }
    public DateTime DataInicio
    {
        get => _dataInicio;
        set
        {
            _dataInicio = value;
            OnPropertyChanged(nameof(DataInicio));
            OnPropertyChanged(nameof(DuracaoDias));
            OnPropertyChanged(nameof(CustoTotal));
        }
    }
    public DateTime DataTermino
    {
        get => _dataTermino;
        set
        {
            _dataTermino = value;
            OnPropertyChanged(nameof(DataTermino));
            OnPropertyChanged(nameof(DuracaoDias));
            OnPropertyChanged(nameof(CustoTotal));
        }
    }
    public int NumeroParticipantes
    {
        get => _numeroParticipantes;
        set
        {
            _numeroParticipantes = value;
            OnPropertyChanged(nameof(NumeroParticipantes));
            OnPropertyChanged(nameof(CustoTotal));
        }
    }
    public string Local { get; set; }
    public decimal CustoPorParticipante
    {
        get => _custoPorParticipante;
        set
        {
            _custoPorParticipante = value;
            OnPropertyChanged(nameof(CustoPorParticipante));
            OnPropertyChanged(nameof(CustoTotal));
        }
    }

    public int DuracaoDias => (DataTermino - DataInicio).Days + 1;
    public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
