using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MPowerKit.Navigation;
using MPowerKit.Navigation.Interfaces;

namespace PopupProblems;

public sealed partial class MainViewModel : ObservableObject
{
    private readonly IPopupNavigationService _popupNavigationService;

    public MainViewModel(IPopupNavigationService popupNavigationService)
    {
        _popupNavigationService = popupNavigationService;
    }

    [RelayCommand]
    public async Task ShowNotificationAsync()
    {
        NavigationResult result = await _popupNavigationService.ShowPopupAsync("NotificationPopupPage");
        await Task.Delay(TimeSpan.FromSeconds(2));
        await _popupNavigationService.HidePopupAsync();
    }
}