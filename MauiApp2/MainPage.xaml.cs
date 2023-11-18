using CommunityToolkit.Mvvm.ComponentModel;
using Xceed.Maui.Toolkit;

namespace MauiApp2;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new ViewModel();
    }
}

public partial class ViewModel : ObservableObject
{
    [ObservableProperty]
    private IEnumerable<DataPoint> _points = [new(1, 10), new(2, 30)];
}
