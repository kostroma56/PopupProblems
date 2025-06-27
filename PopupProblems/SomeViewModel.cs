using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MPowerKit.Navigation.Interfaces;

namespace PopupProblems;

public sealed partial class SomeViewModel : ObservableObject
{
    private readonly IPopupNavigationService _popupNavigationService;
    private readonly INavigationService _navigationService;

    public SomeViewModel(IPopupNavigationService popupNavigationService, INavigationService navigationService)
    {
        _popupNavigationService = popupNavigationService;
        _navigationService = navigationService;
    }

    [RelayCommand]
    private async Task OpenPopupAndGoBack()
    {
        await _popupNavigationService.ShowPopupAsync("SimplePopupPage");
        await _navigationService.GoBackAsync();
    }
}