using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnogoZadachDky8Classa.Param1
{
    internal class one
    {
        /*!
         * Задача 1.1
         * Напишите функцию bool IsUpper(char), которая определяет, является ли входной символ 
         * заглавной буквой латинского алфавита, без использования стандартной библиотеки.
         */
        public bool IsUpper(char symbol)
        {
            if ((symbol >= 'A') && (symbol <= 'Z'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*!
         * Задача 1.2
         * Напишите функцию bool IsDigit(char), которая определяет, 
         * является ли входной символ цифрой, без использования стандартной библиотеки
         */
        public bool IsDigit(char symbol)
        {
            if ((symbol >= '0') && (symbol <= '9'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*!
         * Задача 1.3
         * Напишите функцию char ToUpper(char), которая переводит строчный 
         * символ латинского алфавита в аналогичный заглавный., без использования стандартной библиотеки
         */
        public char ToUpper(char symbol)
        {
            if ((symbol >= 'a') && (symbol <= 'z'))
            {
                return (char)(symbol - 'a' + 'A');
            }
            else
            {
                return '0';
            }

        }

        /*!
         * Задача 1.4
         * Написать рекурсивную функцию для вычисления факториала натурального числа n
         */
        public long Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        /*!
         * Задача 1.5
         * Написать рекурсивную функцию для расчета степени n вещественного числа a (n — натуральное число).
         */
        public double Power(double a, int n)
        {
            if (n == 0)
                return 1;
            else if (n > 0)
                return a * Power(a, n - 1);
            else
                return 1 / Power(a, -n);
        }

        /*!
         * Задача 1.6
         * Написать функцию, которая определяет в какой из двух целочисленных переменных больше цифр
         */
        public int MoreDigits(int num1, int num2)
        {
            int count1 = 0, count2 = 0;

            while (num1 != 0 || num2 != 0)
            {
                if (num1 != 0)
                {
                    num1 /= 10;
                    count1++;
                }
                if (num2 != 0)
                {
                    num2 /= 10;
                    count2++;
                }
            }

            if (count1 > count2)
                return 1;
            else if (count1 < count2)
                return 2;
            else
                return 0;
        }

        /*!
         * Задача 1.7
         * Написать функцию, которая определяет в какой из двух вещественных переменных больше цифр после запятой
         */
        public int CompareDecimalPlaces(double num1, double num2)
        {
            var num1Length = num1.ToString().Split('.')[1].Length;
            var num2Length = num2.ToString().Split('.')[1].Length;

            if (num1Length > num2Length)
            {
                return 1;
            }
            else if (num1Length < num2Length)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        /*!
         * Задача 1.8
         * Написать функцию, которая объединяет два одномерных массива в один, 
         * состоящий только из уникальных элементов, входящие в оба массива
         */
        public T[] MergeArraysUnic<T>(T[] array1, T[] array2)
        {
            return array1.Union(array2).ToArray();
        }

        /*!
         * Задача 1.9
         * Написать функцию, которая объединяет два одномерных массива в один, 
         * состоящих только из элементов входящих в первый массив
         */
        public T[] MergeArraysOne<T>(T[] array1, T[] array2)
        {
            T[] result = new T[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i];
            }

            for (int i = 0; i < array2.Length; i++)
            {
                if (!result.Contains(array2[i]))
                {
                    result[array1.Length + i] = array2[i];
                }
            }

            return result;
        }

        /*!
         * Задача 1.10
         * Написать функцию, которая принимает переменную char, если она оказывается цифрой,
         * то возвращает ее значение типа integer.
         */
        public int GetDigitValueFromChar(char myChar)
        {
            int digitValue = 0;

            if (char.IsDigit(myChar))
            {
                digitValue = myChar - '0';
            }

            return digitValue;
        }

        /*!
         * Задача 1.11
         * Напишите функцию, принимающую три параметра. (Часы, минуты, секунды).
         * Верните эквивалент указанного времени в секундах
         */
        public long ConvertToSeconds(int hours, int minutes, int seconds)
        {
            return hours * 3600 + minutes * 60 + seconds;
        }

        /*!
         * Задача 1.12
         * Напишите две функции. Первая функция заполняет массив случайными
         * значениями, вторая функция выводит массив на экран
         */
        public void FillArray(int[] array, int size)
        {
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, 100);
            }
        }
        public void PrintArray(int[] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        /*!
         * Задача 1.13
         * Написать функцию, генерирующую пароль от 8 до 32 символов, 
         * которая включает буквы, цифры и спец символы
         */
        public string password_generator(int len)
        {
            if (len < 8)
                return "Пароль слишком короткий";
            if (len > 32)
                return "Пароль слишком длинный";
            int[] arr = new int[len];
            Random rnd = new Random();
            string Password = "";

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(33, 125); // Коды символов для пароля
                Password += (char)arr[i];
            }
            return Password;
        }

        /*!
         * Задача 1.14
         * Напишите функцию, которая начинает, записывает с определенной позиции, 
         * в первый массив, все значения второго (без использования стандартной библиотеки)
         */
        static T[] CopyArray<T>(T[] oneMas, T[] twoMas, int startIndex = 0)
        {
            T[] result = new T[oneMas.Length + twoMas.Length];
            for (int i = oneMas.Length; i <= oneMas.Length + twoMas.Length - startIndex; i++)
            {
                result[i] = oneMas[startIndex + i];
            }
            return result;
        }

        /*!
        * Задача 1.15
        * Написать функцию генерации случайного email 
        * адреса формата <name>@<domen>.<local>
        */
        public string GenerateEmail()
        {
            var name = Guid.NewGuid().ToString("N").Substring(0, 8); // Имя
            var domain = Guid.NewGuid().ToString("N").Substring(0, 4); // Домен
            var local = Guid.NewGuid().ToString("N").Substring(0, 4); // Адрас

            return $"{name}@{domain}.{local}";
        }

        /*!
         * Задача 1.16
         * Написать функцию перевода курса валют «рубли в доллары» и на оборот.
         */
        public double ConvertRublesToDollars(double rubles, double rate)
        {
            return rubles / rate; // Рубли на курс
        }

        /*!
         * Задача 1.17
         * Написать функцию, которая принимает в качестве аргумента строку и определяет количество слов в ней
         */
        public int WordCount(string text)
        {
            return text.Split(' ').Length;
        }

        /*!
         * Задача 1.18
         * Написать функцию, которая принимает аргумент целочисленное число и выводит его
         * представление в восьмеричной и шестнадцатеричной системе исчисления
         */
        public void ConvertInt_8_16(int number)
        {
            string tmp =  "В восьмеричной системе: {}" + Convert.ToString(number, 8) +
                "\n В шестнадцатеричной системе: " + Convert.ToString(number, 16);
        }

        /*!
         * Задача 1.19
         * Написать функцию, которая увеличивает размерность массива на заданное количество единиц,
         * с сохранением старых значений
         */
        public int[] ResizeArray(int[] array, int newSize)
        {
            int[] newArray = new int[array.Length + newSize];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = array.Length; i < newArray.Length; i++)
            {
                newArray[i] = 0;
            }

            return newArray;
        }


        /*!
         * Задача 1.20
         * Написать функцию, которая принимает в качестве аргумента массив и возвращает массив,
         * состоящий только из уникальных элементов
         */
        public T[] GetUniqueValues<T>(T[] array)
        {
            var unique = array.Distinct();
            return unique.ToArray();
        }
    }
}
