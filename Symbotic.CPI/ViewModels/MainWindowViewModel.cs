using CommunityToolkit.Mvvm.ComponentModel;

namespace Symbotic.CPI.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; set; } = "Welcome to Avalonia!";

}