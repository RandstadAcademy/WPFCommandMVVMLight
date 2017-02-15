using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1
{
  public class MyCommand : ICommand
  {
    private Action _executeCode;
    private Func<bool> _canExecuteCode;

    public event EventHandler CanExecuteChanged;

    public MyCommand(Action executeCode)
    {
      _executeCode = executeCode;
    }
    public MyCommand(Action executeCode, Func<bool> canExecuteCode)
    {
      _executeCode = executeCode;
      _canExecuteCode = canExecuteCode;
    }

    public bool CanExecute(object parameter)
    {
      if (_canExecuteCode != null)
        return _canExecuteCode();

      return true;
    }

    public void Execute(object parameter)
    {
      if (_executeCode != null)
        _executeCode();
    }
  }
}
