using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();
            //task4();
            //task5();
            //task6();
            //task7();
            //task8();
            //task10();
            //task14();
            //task21();
            //task22();
            //task23();
            //task24();
            //task26();
        }
        /// <summary>
        /// 1.	Напечатать весь массив целых чисел
        /// </summary>
        static void task1()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach(int number in arr)
            {
                Console.WriteLine(number);
            }
        }
        /// <summary>
        /// 2.	Найти индекс максимального значения в массиве (воспользоваться функцией)
        /// </summary>
        static void task2()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int maxIndex = Array.FindLastIndex(arr, _ => true);

            Console.WriteLine("Максимальный индекс = {0}", maxIndex);
        }
        /// <summary>
        /// 3.	Найти индекс максимального четного значения в массиве
        /// </summary>
        static void task3()
        {
            int[] arr = { 1, 42, 24, 56, 23, 99, 33 };

            int maxIndex = Array.FindLastIndex(arr, _ => true);

            int maxNumber= int.MinValue;

            foreach (int number in arr)
            {
                if (number % 2 == 0 && number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            var maxNumberIndex = Array.IndexOf(arr, maxNumber);

            Console.WriteLine("Индекс максимального четного значения: {0}", maxNumberIndex);
        }
        /// <summary>
        /// 4.	Удалить элемент из массива по индексу.
        /// </summary>
        static void task4()
        {
            int[] arr = { 1, 42, 24, 56, 23, 99, 33 };

            Console.Write("Введите индекс, который хотите удалить из массива: ");

            int indexDelete = Convert.ToInt32(Console.ReadLine());

            List<int> list = new List<int>(arr);

            if (indexDelete >= 0 && indexDelete < list.Count)
            {
                list.RemoveAt(indexDelete);
                arr = list.ToArray();

                Console.WriteLine("Элемент с индексом {0}",  indexDelete + " был удален");
            }
            else
                Console.WriteLine("error");

            Console.WriteLine("Массив с удаленным индексом: \n");

            foreach(int number in arr)
            {
                Console.Write(number + " ");
            }
        }
        /// <summary>
        /// 5.	Удаление элементов из массива по значению
        /// </summary>
        static void task5()
        {
            int[] arr = { 1, 42, 24, 56, 23, 99, 33 };

            Console.Write("Введите значение, которое хотите удалить из массива: ");

            bool remove = false;

            int numberDelete = Convert.ToInt32(Console.ReadLine());

            List<int> list = new List<int>(arr);

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] == numberDelete)
                {
                    list.RemoveAt(i);
                    remove = true;
                }
            }

            if (remove)
            {
                arr = list.ToArray();
                Console.WriteLine("Массив с удаленным значением: \n");
                
                foreach (int number in arr)
                {
                    Console.Write(number + " ");
                }
            }
            else
            {
                Console.WriteLine("Значение не найдено в массиве.");
            }
        }
        /// <summary>
        /// 6.	Вставить элемент в массив по индексу
        /// </summary>
        static void task6()
        {
            int[] arr = { 1, 42, 24, 56, 23, 99, 33 };

            Console.Write("Введите элемент, который хотите вставить по индексу: ");
            int insertNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите индекс элемента, который хотите вставить в массив: ");
            int index = Convert.ToInt32(Console.ReadLine());
            
            if(index >= 0 && index <= arr.Length)
            {
                int[] newArr = new int[arr.Length + 1];

                for (int i = 0; i < index; i++)
                {
                    newArr[i] = arr[i];
                }
                newArr[index] = insertNumber;

                for (int i = index; i < arr.Length; i++)
                {
                    newArr[i+1] = arr[i];
                }

                arr = newArr;

                Console.WriteLine("Элемент {0}", insertNumber + " вставлен по индексу " + index);

            }
            else
            {
                Console.WriteLine("Индекс не корректен (нельзя вставить этот индекс, так как рядом нет соседних, куда можно было бы вставить");
            }

            Console.WriteLine("Updated Array: ");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// 7.	Удалить те элементы массива, 
        ///     которые встречаются в нем ровно два раза
        /// </summary>
        static void task7()
        {
            int[] arr = { 1, 42, 24, 42, 23, 99, 99, 5, 6, 7, 6, 10 };

            var temp = new System.Collections.Generic.List<int>();

            Console.WriteLine("Массив до: ");

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            
            foreach (int i in arr)
            {
                int count = arr.Count(x => x == i);

                if (count != 2)
                {
                    temp.Add(i);
                }
            }

            arr = temp.ToArray();

            Console.WriteLine("\nМассив после: ");

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
        /// <summary>
        /// 8.	Удалить из строки слова, в которых есть буква 'a'
        /// </summary>
        static void task8()
        {
            string s = "а-а-а-а-а горький вкус твоей любви Меня убил, теперь без сил А ты змея пустила яд Любовный яд, а я так рад Что все прошло, а может быть И не было и ничего Прощай, прощай и никогда Меня, прошу, не вспоминай";
            
            //Console.Write("Введите строку: ");
            //string s = Console.ReadLine();

            Console.WriteLine(s.Replace("а", String.Empty));

        }
        /// <summary>
        /// 10.	В строке все слова, которые начинаются и 
        ///     заканчиваются одной буквой, 
        ///     выделить квадратными скобками
        /// </summary>
        static void task10()
        {
            Console.Write("Введите строку: ");

            string s = Console.ReadLine();

            string temp = "";

            for (int i = 0; i <= s.Length; i++)
            {
                if ((i == s.Length) || (s[i] == ' '))
                {
                    if (temp.Length == 0)
                        continue;

                    if (temp[0] == temp[temp.Length - 1])
                    {
                        Console.Write("[" + temp + "] ");
                    }
                    else
                    {
                        Console.Write(temp + " ");
                    }

                    temp = "";
                }
                else
                {
                    temp += s[i];
                }
            }
        }

        /// <summary>
        /// 14.	Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. 
        /// Программа должна сосчитать количество введенных пользователем пробелов. (Подсказка. IF, Length)
        /// </summary>
        static void task14()
        {
            Console.WriteLine("Введите строку с символами и для её завершения введите точку '.'");

            int space = 0;

            while (true)
            {
                string str = Console.ReadLine();

                if(str == ".")
                    break;
                for(int i =0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        space++;
                    }
                }
            }
            Console.WriteLine("Кол-во введенных пробелов: {0}", space);
        }

        /// <summary>
        /// 21.	Составьте программу, которая в слове «класс» две одинаковые буквы заменяет цифрой «1»
        /// </summary>
        static void task21()
        {
            string str = "Класс";
            string s = str.Replace("сс", "11");

            Console.WriteLine("Замена: " + s);
        }

        /// <summary>
        /// 22.	Написать программу, подсчитывающую количество цифр в заданной строке.
        /// </summary>
        static void task22()
        {
            Console.WriteLine("Введите строку с символами и для её завершения введите точку '.'");

            int count = 0;

            while (true)
            {
                string str = Console.ReadLine();

                if (str == ".")
                    break;

                for (int i = 0; i < str.Length; i++)
                {
                    char ch = str[i];

                    // Проверка
                    if (char.IsDigit(ch))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Количество введенных цифр: {0}", count);
        }

        /// <summary>
        /// 23.	Дан текст. Определить, есть ли в тексте слово one.
        /// </summary>
        static void task23()
        {
            Console.WriteLine("Введите строку с символами и для её завершения введите точку '.'");

            bool isOne = false;

            while (true)
            {
                string str = Console.ReadLine();

                if (str == ".")
                    break;

                if (str.Contains("one"))
                {
                    isOne = true;
                    break;
                }
            }

            if (isOne)
            {
                Console.WriteLine("В тексте есть слово 'one'");
            }
            else
            {
                Console.WriteLine("В тексте нет слова 'one'");
            }
        }

        /// <summary>
        /// 24.	Дан текст. Определить, содержит ли он символы, отличающиеся от букв и цифр.
        /// </summary>
        static void task24()
        {
            Console.WriteLine("Введите строку с символами и для её завершения введите точку '.'");

            bool isSymbol = false;

            while (true)
            {
                string str = Console.ReadLine();

                if (str == ".")
                    break;
                for (int i = 0; i < str.Length; i++)
                {
                    if (!char.IsLetterOrDigit(str[i]))
                    {
                    isSymbol = true;
                    break;
                    }
                }
            }
            if (isSymbol)
            {
                Console.WriteLine("В тексте есть символы, отличающиеся от букв и цифр");
            }
            else
            {
                Console.WriteLine("В тексте нет символов, отличающихся от букв и цифр");
            }
        }
        /// <summary>
        /// 26.	Дана строка, посчитать количество вхождений буквы P.
        /// </summary>
        static void task26()
        {
            Console.WriteLine("Введите строку и для её завершения введите точку '.'");

            int P = 0;

            while (true)
            {
                string str = Console.ReadLine();

                if (str == ".")
                    break;
                for (int i = 0; i < str.Length; i++)
                {
                    //если нужно с нижним регистров и с заглавной буквой
                    if (str[i] == 'Р' || str[i] == 'р')
                    {
                        P++;
                    }

                    /*  чисто если только букву с заглавной Р
                        if (str[i] == 'Р')
                        {
                           P++;
                        }
                    */
                }
            }
            Console.WriteLine("Кол-во введенных P: {0}", P);
        }
    }
}
