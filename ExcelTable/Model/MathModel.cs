using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTable.Model
{
   public static class MathModel//эото класс иддет в Model данные и логика, как бы черная коробка которую просто иисопльзуют
    //она незнает ни о ком, Модель описывает используемые в приложении данные. Модели могут содержать логику,
    //непосредственно связанную этими данными, например, логику валидации свойств модели.
    //В то же время модель не должна содержать никакой логики, связанной с отображением данных и
    //взаимодействием с визуальными элементами управления.

    //прямое взаимодействие между Model и View отсутствует
    {
        public static int GetSumOf(int a, int b) => a + b;

       
    }
}
