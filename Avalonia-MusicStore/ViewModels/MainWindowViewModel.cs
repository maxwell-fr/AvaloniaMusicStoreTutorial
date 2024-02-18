using System.Windows.Input;
using ReactiveUI;

namespace AvaloniaMusicStore.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ICommand BuyMusicCommand { get; }

    public MainWindowViewModel()
    {
        BuyMusicCommand = ReactiveCommand.Create(() =>
        {

        });
    }
}