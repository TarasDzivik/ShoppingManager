﻿using SM.Mobile.ViewModels.Commands.Abstract;
using SM.Mobile.ViewModels.Navigations.Stores;

namespace SM.Mobile.ViewModels.Commands;
public class NavigateCommand<TVM> : CommandBase where TVM : ViewModelBase
{
    private readonly NavigationStore _navigationStore;
    private readonly Func<TVM> _createVM;
    public NavigateCommand(NavigationStore navigationStore, Func<TVM> CreateVM)
    {
        _navigationStore = navigationStore;
        _createVM = CreateVM;
    }

    public override void Execute(object? parameter) => _navigationStore.CurrentViewModel = _createVM();

}
