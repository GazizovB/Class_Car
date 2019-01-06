using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Homework
{
    public partial class Car
    {
        //Статический конструктор 
        static Car()   //не указываем модификаторы доступа
        {
            _cost = 243254500;
        }
    }
}
