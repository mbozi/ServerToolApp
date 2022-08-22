using System.Windows;

namespace ServerTool.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public MainWindow(object dataContext)
    {
        InitializeComponent();
        DataContext = dataContext;
    }
}
