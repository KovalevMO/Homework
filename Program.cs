using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача №1             
            /* Максим Ковалев
            Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
            а) используя склеивание */

            Console.Write("Введи свое имя: ");
            String firstName = Console.ReadLine();
            
            Console.Write("Введи свою фамилию: ");
            String lastName = Console.ReadLine();

            Console.Write("Введи свой возраст: ");
            String age = Console.ReadLine();

            Console.Write("Введи свой рост: ");
            String height = Console.ReadLine();

            Console.Write("Введи свой вес: ");
            String weight = Console.ReadLine();

            Console.WriteLine("Привет, " + firstName + " " + lastName + "! Тебе " + age + " лет, твой рост - " + height + " см, а вес - " + weight + "кг. (Метод склеивания)");
            Console.ReadLine();

            //б) используя форматированный вывод 
            
            Console.WriteLine("Привет, {0} {1}! Тебе {2} лет, твой рост - {3} см, а вес - {4}кг. (Метод форматированного вывода)", firstName, lastName, age, height, weight);
            Console.ReadLine();

            //в) используя вывод со знаком $
            
            Console.WriteLine($"Привет, {firstName} {lastName}! Тебе {age} лет, твой рост - {height}см, а вес -  {weight}кг. (Метод вывода со знаком $)");
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Задача №2

            // Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.

            Console.Write("Расчет ИМТ человека! Введите массу тела в килограммах: ");
            double weight2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите рост человека в метрах: ");
            double height2 = Convert.ToDouble(Console.ReadLine());
            double I = Convert.ToDouble (weight2 / (height2 * height2));
            I = Math.Round(I, 2);
            Console.WriteLine("Индекс массы тела человека = " + I);
            Console.ReadLine();

            #endregion

            #region Задача №3
            //Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
            //по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой)

            Console.Write("Введите координату x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(r.ToString("F2"));

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Задача №4

            // Написать программу обмена значениями двух переменных:
            // а) с использованием третьей переменной;
            Console.Write("Введите значение переменной а: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите значение переменной b: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Переменная а = {a},\n" + $"Переменная b = {b}.");
            Console.ReadLine();
            int t = b; 
            b = a; 
            a = t;
            Console.WriteLine("После обмена значениями \n" + $"Переменная а = {a},\nПеременная b = {b}.");
            Console.ReadLine();

            // б) *без использования третьей переменной.
            Console.Write("Введите значение переменной а: ");
            int a1 = Int32.Parse(Console.ReadLine());
            Console.Write("Введите значение переменной b: ");
            int b1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Переменная а = {a1},\n" + $"Переменная b = {b1}.");
            b1 = a1 + b1;
            a1 = b1 - a1;
            b1 = b1 - a1;
            Console.WriteLine("После обмена значениями \n" + $"Переменная а = {a1},\nПеременная b = {b1}.");
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Задача №5            
            // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.

            Console.WriteLine("Введите в одну строку через пробел ваше имя, фамилию, город проживания");
            string line = Console.ReadLine();
            string[] arg = line.Split();

            Console.WriteLine($"Вас зовут {arg[0]} {arg[1]}, Вы живете в городе {arg[2]}.");
            Console.ReadLine();
            #endregion
        }
    }
}
