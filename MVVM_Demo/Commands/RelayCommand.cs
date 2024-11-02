using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Demo.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action<object> _Excute { get; set; }
        Predicate<object> _CanExcute {  get; set; }

        public RelayCommand(Action<object> ExcuteMethod, Predicate<object> CanExcuteMethod)
        {
            _Excute = ExcuteMethod;
            _CanExcute = CanExcuteMethod;
        }
        public bool CanExecute(object parameter)
        {
           return _CanExcute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            _Excute.Invoke(parameter);
        }
    }
}
