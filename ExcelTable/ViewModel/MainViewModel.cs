using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ExcelTable.Annotations;

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
        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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

        public string _word;

        public string Word
        {
            get
            {
                return _word;
            }
            set
            {
                _word = value;
                    OnPropertyChanged(nameof(Word));

            }
        }

        public MainViewModel()
        {
            Task.Factory.StartNew(() =>
            {
                while (Clicks <10)
                {
                    Task.Delay(1000).Wait();
                    Clicks++;
                    if (_clicks == 10)
                    {
                        Word = "Hello";
                        Clicks = 0;
                    }
                }
            });

           
        }
    }
}
