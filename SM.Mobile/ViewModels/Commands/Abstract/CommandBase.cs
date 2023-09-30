using System.Windows.Input;

namespace SM.Mobile.ViewModels.Commands.Abstract;
/// <summary>
/// Abstract interface used as a main body for the application commands.
/// </summary>
public abstract class CommandBase : ICommand
{
    public event EventHandler? CanExecuteChanged;

    public virtual bool CanExecute(object parameter) => true;

    public abstract void Execute(object parameter);

    /// <summary>
    /// Change occured that affect whether command should be executed or not.
    /// </summary>
    protected void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, new EventArgs());
}
