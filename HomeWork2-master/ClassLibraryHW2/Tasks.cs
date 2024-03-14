using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ClassLibraryHW2
{
    public class Task1
    {
        public static void minNum(float a, float b, float c)
        {
            float min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }
            Console.WriteLine(min);
        }

        public static void TaskOne()
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine();
            Console.WriteLine("Введите 3 числа: ");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("Минимальное число: ");
            minNum(a, b, c);
        }
    }

    public class Task2
    {
        public static void NumberOfDigits(int a)
        {
            int count = 0;
            while (a > 0)
            {
                count++;
                a /= 10;
            }
            Console.WriteLine(count);
        }

        public static void TaskTwo()
        {
            Console.WriteLine("Задача 2");
            Console.WriteLine();
            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Количество цифр числа {a}: ");
            NumberOfDigits(a);
        }
    }

    public class Task3
    {
        public static void NumberOfOddPlusInteger(List<int> vec_of_nums)
        {
            int count = 0;
            for (int i = 0; i < vec_of_nums.Count(); i++)
            {
                if (vec_of_nums[i] % 2 > 0) { count += vec_of_nums[i]; }
            }
            Console.WriteLine(count);
        }

        public static void TaskThree()
        {
            Console.WriteLine("Задача 3");
            Console.WriteLine();
            Console.WriteLine("Введите числа: ");
            List<int> vec_of_nums = new List<int>();
            int a = int.Parse(Console.ReadLine());
            while (a != 0)
            {
                vec_of_nums.Add(a);
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Сумма всех нечетных положительных чисел: ");
            NumberOfOddPlusInteger(vec_of_nums);
        }
    }

    public class Task4
    {
        public static void Authorization(string login, string password)
        {
            int count = 3;
            if (password != "ITTop")
            {
                do
                {
                    count--;
                    if (count == 0) { Console.WriteLine($"Неверный пароль. Больше попыток нет."); break; }
                    Console.WriteLine($"Неверный пароль. Осталось попыток: {count}. Введите пароль: ");
                    password = Console.ReadLine();
                } while (password != "ITTop");
            }
            if (count > 0) { Console.WriteLine("Успешный вход"); }; 
        }

        public static void TaskFour()
        {
            Console.WriteLine("Задача 4");
            Console.WriteLine();
            Console.WriteLine("Введите логин: ");
            string login = Console.ReadLine();
            while (login != "root")
            {
                Console.WriteLine("Такого пользователя не существует. Введите корректный логин: ");
                login = Console.ReadLine();
            }
            Console.WriteLine("Введите пароль: ");
            string password = Console.ReadLine();
            Authorization(login, password);
        }
    }

    public class Task5
    {
        public static void IMT(float weight, float height)
        {
            double IMT = weight / height / height;
            string resIMT = string.Format("{0:f2}", IMT);
            double m;
            Console.WriteLine("Ваш индекс массы тела: " + resIMT);
            if (IMT < 18.5)
            {
                m = (18.5 - IMT) * height * height;
                string res = string.Format("{0:f2}", m);
                Console.WriteLine("Вам следует набрать " + res + " кг." );
            }
            else if (IMT > 25)
            {
                m = ((IMT - 25) * height * height);
                string res = string.Format("{0:f2}", m);
                Console.WriteLine("Вам следует скинуть " + res + " кг.");
            }
            else {
                Console.WriteLine("У вас нормальный ИМТ");
            }

        }
        public static void TaskFive()
        {            
            Console.WriteLine("Задача 5");
            Console.WriteLine();
            Console.WriteLine("Введите вес в килограммах: ");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост в метрах: ");
            float height = float.Parse(Console.ReadLine());

            IMT (weight, height);

        }
    }

    public class Task7
    {

    }
}
