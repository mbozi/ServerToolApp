using ServerTool.Navigation;
using ServerTool.ViewModels;

namespace ServerTool;
public class NavigationFactory : INavigationFactory
{
    private readonly VModel<ViewModelFiles> _viewModelFiles;
    private readonly VModel<ViewModelSQL> _viewModelSQL;

    public NavigationFactory(
        VModel<ViewModelFiles> viewModelFiles,
        VModel<ViewModelSQL> viewModelSQL
        )
    {
        _viewModelFiles = viewModelFiles;
        _viewModelSQL = viewModelSQL;
    }

    public BaseViewModel SelectViewModel(ViewModelName viewType)
    {
        return viewType switch
        {
            ViewModelName.Files => _viewModelFiles(),
            ViewModelName.SQL => _viewModelSQL(),
            _ => _viewModelFiles(),
        };
    }
}