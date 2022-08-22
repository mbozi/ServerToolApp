using ServerTool.ViewModels;

namespace ServerTool.Navigation;

public interface INavigationFactory
{
    BaseViewModel SelectViewModel(ViewModelName viewType);
}

