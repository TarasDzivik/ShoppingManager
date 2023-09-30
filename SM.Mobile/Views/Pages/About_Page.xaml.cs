using SM.Mobile.ViewModels;

namespace SM.Mobile.Views.Pages;

public partial class About_Page : ContentPage
{
    public About_Page()
    {
        BindingContext = new About_ViewModel();
        InitializeComponent();
    }
}