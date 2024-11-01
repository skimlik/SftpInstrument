using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SftpInstrument.Infrastructure;

public class ViewModelBase : INotifyPropertyChanged
{
    private string _title;
    public event PropertyChangedEventHandler PropertyChanged;

    public string Title { get => _title; set => SetField(ref _title, value); }

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}