using CommunityToolkit.Mvvm.ComponentModel;

namespace SM.Mobile.Model;
[ObservableObject]
public partial class Preference
{
    [ObservableProperty] private string preferencePrompt;
    [ObservableProperty] private string preferenceValue;
}