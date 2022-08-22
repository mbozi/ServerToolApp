using ServerTool.Commands;

namespace ServerTool.Navigation;

public class ViewModelSetCommand : BaseCommand
{
    private readonly INavigationStore _navigator;

    public ViewModelSetCommand(INavigationStore navigator)
    {
        _navigator = navigator;
    }

    public override void Execute(object? parameter)
    {
        if (parameter is CommandArgsViewModel vmca)
        {
            if (vmca.IsModalOpen)
            {
                _navigator.TypeParameters = vmca.Value;
                _navigator.ViewModelCurrentTypeModal = vmca.ViewModel;
                _navigator.ModalIsOpen = (vmca.CommandType == CommandTypeViewModel.ModalNew);
            }
            else
            {
                _navigator.TypeParameters = vmca.Value;
                _navigator.ViewModelCurrentType = vmca.ViewModel;
                _navigator.ModalIsOpen = false;
            }

        }
    }
}
