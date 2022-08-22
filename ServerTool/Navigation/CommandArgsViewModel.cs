namespace ServerTool.Navigation;
public class CommandArgsViewModel
{
    public CommandArgsViewModel(ViewModelName vMName, CommandTypeViewModel commandType, string value)
    {
        ViewModel = vMName;
        IsModalOpen = (commandType == CommandTypeViewModel.ModalNew);
        Value = value;
        CommandType = commandType;
    }

    public ViewModelName ViewModel { get; }
    public bool IsModalOpen { get; }
    public string Value { get; }
    public CommandTypeViewModel CommandType { get; }
}
