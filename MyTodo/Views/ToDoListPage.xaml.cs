using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodo.Views;

public partial class ToDoListPage : ContentPage
{
    public ToDoListPage()
    {
        InitializeComponent();
        BindingContext = App.MainViewModel;
    }
}