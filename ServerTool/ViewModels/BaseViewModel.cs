using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace ServerTool.ViewModels;

public delegate TViewModel VModel<TViewModel>() where TViewModel : BaseViewModel;
public class BaseViewModel : ObservableObject, IDisposable
{
    public ICommand? UpdateViewModelCommand { get; set; }

    protected void OnPropertyChanged(List<string> properties)
    {
        if (properties == null) return;
        foreach (string p in properties) OnPropertyChanged(p); 
    }

    public void Dispose()
    { }

}
