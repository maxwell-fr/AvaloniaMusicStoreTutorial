using System.Reactive.Linq;
using System.Windows.Input;
using ReactiveUI;

namespace AvaloniaMusicStore.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ICommand BuyMusicCommand { get; }
    public Interaction<MusicStoreViewModel, AlbumViewModel?> ShowDialog { get; }


    public MainWindowViewModel()
    {
        ShowDialog = new Interaction<MusicStoreViewModel, AlbumViewModel>();

        BuyMusicCommand = ReactiveCommand.Create(async () =>
        {
            var store = new MusicStoreViewModel();
            var result = await ShowDialog.Handle(store);


        });
    }
}