using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Homework
{
       public partial class Car
    {
        //Поля класса
        public string _model;
        private static int _cost;
        private static double _mass;
        public DateTime _date;
        public int _mileage;

        //Методы класса
        public void SetDescribe(int cost)
        {
            _cost = cost;
        }
        public int GetDescribe()
        {
            return _cost;
        }

        //Перегруженный конструктор
        public Car(string model, DateTime date, int mileage, int mass)
        {
            _model = model;
            _date = date;
            _mileage = mileage;
            _mass = mass;
        }

        public string ShowCar() //Метод ShowCar
        {
            return $"Модель: {_model}\nСтоимость: {_cost}\nDate: {_date}\nПробег: {_mileage}\nMass: {_mass}"; 
        }

        //Конструктор без параметра
        public Car() { }

        //Метод PrintArray (показывает массив эл.)
        public void PrintArray(int[] number)
        {
            Console.Write("Массив элементов: ");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i]);
            }
        }

    }
}
