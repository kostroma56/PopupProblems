using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MPowerKit.Navigation;
using MPowerKit.Navigation.Interfaces;

namespace PopupProblems;

public sealed partial class SimpleViewModel : ObservableObject
{
    private readonly IPopupNavigationService _popupNavigationService;

    public SimpleViewModel(IPopupNavigationService popupNavigationService)
    {
        _popupNavigationService = popupNavigationService;
    }

    [RelayCommand]
    private async Task ClosePopupAsync()
    {
        NavigationResult result = await _popupNavigationService.HidePopupAsync();
    }
}