using MyTodo.Models;

namespace MyTodo;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = App.MainViewModel;
        DateLabel.Text = DateTime.Now.ToString("D");
    }
}