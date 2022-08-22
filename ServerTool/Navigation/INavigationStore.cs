using ServerTool.ViewModels;
using System;
using System.Windows.Input;

namespace ServerTool.Navigation;

public interface INavigationStore
{
    bool ModalIsOpen { get; set; }
    string? TypeParameters { get; set; }
    BaseViewModel? ViewModelCurrent { get; set; }
    BaseViewModel? ViewModelCurrentModal { get; set; }
    ViewModelName ViewModelCurrentType { get; set; }
    ViewModelName ViewModelCurrentTypeModal { get; set; }
    ICommand VMCommand { get; }

    event Action? ModalStateChanged;
    event Action? StateChanged;
}