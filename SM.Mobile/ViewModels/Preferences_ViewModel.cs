using CommunityToolkit.Mvvm.ComponentModel;
using SM.Mobile.Services;

namespace SM.Mobile.ViewModels;
[ObservableObject]
public partial class Preferences_ViewModel
{
    [ObservableProperty]
    private List<Model.Preference> preferences;

    private readonly PreferenceService service;
    public Preferences_ViewModel()
    {
        service = new();
    }
    public async Task Init()
    {
        Preferences = await service.GetPreferences();
    }
}
