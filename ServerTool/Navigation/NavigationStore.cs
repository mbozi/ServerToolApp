using System.Windows.Input;
using System;
using ServerTool.ViewModels;

namespace ServerTool.Navigation;

public class NavigationStore : INavigationStore
{
    public NavigationStore(INavigationFactory navigationFactory)
    {
        _navigationFactory = navigationFactory;
        VMCommand = new ViewModelSetCommand(this);
        ModalIsOpen = false;
    }


    public ICommand VMCommand { get; private set; }

    private BaseViewModel? _viewModelCurrent;
    private ViewModelName _viewModelCurrentType;
    private ViewModelName _viewModelCurrentTypeModal;

    private readonly INavigationFactory _navigationFactory;

    private bool _modalIsOpen;

    public event Action? StateChanged;
    public event Action? ModalStateChanged;

    public ViewModelName ViewModelCurrentType
    {
        get
        {
            return _viewModelCurrentType;
        }
        set
        {
            if (value is ViewModelName val)
            {
                _viewModelCurrentType = val;
                ViewModelCurrent = _navigationFactory.SelectViewModel(val);
            }
        }
    }
    public BaseViewModel? ViewModelCurrent
    {
        get => _viewModelCurrent;
        set
        {
            _viewModelCurrent = value!;
            StateChanged?.Invoke();
        }
    }
    public ViewModelName ViewModelCurrentTypeModal
    {
        get
        {
            return _viewModelCurrentTypeModal;
        }
        set
        {
            _viewModelCurrentTypeModal = value;
            ViewModelCurrentModal = _navigationFactory.SelectViewModel(value);
        }
    }
    public BaseViewModel? ViewModelCurrentModal { get; set; }
    public bool ModalIsOpen
    {
        get => _modalIsOpen;
        set
        {
            _modalIsOpen = value;
            ModalStateChanged?.Invoke();
        }
    }
    public string? TypeParameters { get; set; }

}

