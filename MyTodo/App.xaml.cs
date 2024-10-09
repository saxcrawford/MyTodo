using MyTodo.Models;

namespace MyTodo;

public partial class App : Application
{
    public static MainViewModel MainViewModel { get; } = new MainViewModel();
    
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}