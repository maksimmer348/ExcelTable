using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ExcelTable.Annotations;
using ExcelTable.Model;

namespace ExcelTable.ViewModel
{
    class MainViewModel : INotifyPropertyChanged//класс находится в ViewModel прослойка междду View и Model

    //ViewModel или модель представления связывает модель и представление через механизм привязки данных.
    //Если в модели изменяются значения свойств, при реализации моделью интерфейса INotifyPropertyChanged
    //автоматически идет изменение отображаемых данных в представлении, хотя напрямую модель и представление
    //не связаны.

    //ViewModel также содержит логику по получению данных из модели, которые потом передаются в представление.
    //И также VewModel определяет логику по обновлению данных в модели

    //Например, пользователь хочет сохранить введенные в текстовое поле данные. Он нажимает на кнопку и тем
    //самым отправляет команду во ViewModel. А ViewModel уже получает переданные данные и в соответствии с ними обновляет модель.
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private int _clicks;

        public int Clicks
        {
            get { return _clicks; }
            set
            {
                _clicks = value;
                OnPropertyChanged(nameof(Clicks));
            }


        }

        private int _number1;
        public int Number1
        {
            get { return _number1; }
            set
            {
                _number1 = value;
                OnPropertyChanged(nameof(Number3)); // уведомление View о том, что изменилась сумма
            }
        }
        private int _number2;

        public int Number2
        {
            get { return _number2; }
            set { _number2 = value; OnPropertyChanged(nameof(Number3)); }
        }


        public int Number3
        {
            get
            {
                return MathModel.GetSumOf(Number1, Number2);
            }
        }


      
        public MainViewModel()
        {
            
        }
    }
}
