using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MPowerKit.Navigation;
using MPowerKit.Navigation.Interfaces;

namespace PopupProblems;

public sealed partial class MainViewModel : ObservableObject
{
    private readonly IPopupNavigationService _popupNavigationService;
    private readonly INavigationService _navigationService;

    public MainViewModel(IPopupNavigationService popupNavigationService, INavigationService navigationService)
    {
        _popupNavigationService = popupNavigationService;
        _navigationService = navigationService;
    }

    [RelayCommand]
    public async Task ShowNotificationAsync()
    {
        NavigationResult result = await _popupNavigationService.ShowPopupAsync("NotificationPopupPage");
        await Task.Delay(TimeSpan.FromSeconds(2));
        await _popupNavigationService.HidePopupAsync();
    }

    [RelayCommand]
    public async Task NavigateWithPopupAsync()
    {
        await _navigationService.NavigateAsync("SomePage");
    }
}