using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Demo
{
    public class MyICommand : ICommand
    {
        public event EventHandler CanExecuteChanged = delegate { };
        private readonly Action _TargetExecuteMethode;
        private readonly Func<bool> _TargetCanExecuteMethode;
        public MyICommand(Action executeMethode) => _TargetExecuteMethode = executeMethode;

        public MyICommand(Action executeMethode, Func<bool> canExecuteMethode)
        {
            _TargetExecuteMethode = executeMethode;
            _TargetCanExecuteMethode = canExecuteMethode;
        }

        public void RaiseCanExecuteChanged() => CanExecuteChanged(this, EventArgs.Empty);        

        public bool CanExecute(object parameter)
        {
            if (_TargetCanExecuteMethode != null)
            {
                return _TargetCanExecuteMethode();
            }
            if (_TargetExecuteMethode != null)
            {
                return _TargetCanExecuteMethode();
            }
            return false;
        }

        public void Execute(object parameter)
        {
            if(_TargetExecuteMethode != null)
            {
                _TargetExecuteMethode();
            }
        }
    }
}
