using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShopAdo3tier.UI.Infrastructure
{
    // класс для реализации механизма комманд 
    internal class RelayCommand : ICommand //реализуем интерфейс ICommand
    {
        private readonly Action<object> action;       //поле, которое хранит метод, вызывающийся при выполнении комманды
        private readonly Predicate<object> predicate; //поле, которое хранит метод, который будет определят возможность выполнения комманды

        public RelayCommand(Action<object> action, Predicate<object> predicate = null)
        {
            this.action = action;
            this.predicate = predicate;
        }

        public event EventHandler CanExecuteChanged//событие `CanExecuteChanged` используется для уведомления об изменении состояния выполнения команды. 
        {                                               //Когда состояние изменяется, обработчики этого события вызываются, 
            add                                             //что позволяет обновить возможность выполнения команды в пользовательском интерфейсе.
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }


        public bool CanExecute(object parameter) //определает условие выполнения комманды return
        {
            return predicate == null ? true : predicate(parameter); //predicate если null возвращаем true, а иначе вызываем метод predicate(parameter);
        }

        public void Execute(object parameter)
        {
            action(parameter); // вызываем делегат action и передаём параметр (parameter)
        }
    }
}
