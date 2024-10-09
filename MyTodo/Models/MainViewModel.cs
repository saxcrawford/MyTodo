using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace MyTodo.Models;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Items = new ObservableCollection<string>();
    }
    
    [ObservableProperty]
    ObservableCollection<string> items;
    
    [ObservableProperty]
    string text;

    [ICommand]
    void Add()
    {
        if (string.IsNullOrEmpty(Text))
        {
            return;
        }
        Items.Add(text);
        Text = string.Empty;
    }

    [ICommand]
    void Delete(string s)
    {
        if (Items.Contains(s))
        {
            Items.Remove(s);
        }
        
    }
}