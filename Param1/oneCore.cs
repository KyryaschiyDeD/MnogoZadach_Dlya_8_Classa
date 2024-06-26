using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnogoZadachDky8Classa.Param1
{
    internal class oneCore
    {
        public void GetValueJob(int butNum, string elt1, string elt2, string elt3)
        {
            if (elt1 == null && butNum != 15)
            {
                Zadacha1.label.Text = "Ввод пуст";
                return;
            }
            else
            if ((butNum >=5 && butNum <= 9) || butNum == 16 || butNum == 19)
            {
                if (elt1 == null || elt2 == null)
                {
                    Zadacha1.label.Text = "Ввод пуст";
                    return;
                }
            }
            else
            if (butNum == 11 || butNum == 14)
            {
                if (elt1 == null || elt2 == null || elt3 == null)
                {
                    Zadacha1.label.Text = "Ввод пуст";
                    return;
                }
            }

            switch (butNum)
            {
                case 1:
                    {
                        if (elt1.Length == 1)
                            Zadacha1.label.Text = IsUpper(Convert.ToChar(elt1)).ToString();
                        else
                            Zadacha1.label.Text = "Строка не является символом";
                    }
                    break;
                case 2:
                    {
                        if (elt1.Length == 1)
                            Zadacha1.label.Text = IsDigit(Convert.ToChar(elt1)).ToString();
                        else
                            Zadacha1.label.Text = "Строка не является символом";
                    }
                    break;
                case 3:
                    {
                        if (elt1.Length == 1)
                            Zadacha1.label.Text = ToUpper(Convert.ToChar(elt1)).ToString();
                        else
                            Zadacha1.label.Text = "Строка не является символом";
                    }
                    break;
                case 4:
                    {
                        if (elt1.Length == 1)
                            Zadacha1.label.Text = Factorial(Convert.ToInt32(elt1)).ToString();
                        else
                            Zadacha1.label.Text = "Строка не является числом";
                    }
                    break;
                case 5:
                    {
                        int ch;
                        double number;
                        bool isDouble = Double.TryParse(elt1, out number);
                        bool isInt = Int32.TryParse(elt2, out ch);
                        if (isDouble && isInt)
                            Zadacha1.label.Text = Power(number, ch).ToString();
                        else
                            Zadacha1.label.Text = "Неверные входные данные";
                    }
                    break;
                case 6:
                    {
                        int ch1, ch2;
                        bool isInt1 = Int32.TryParse(elt1, out ch1);
                        bool isInt2 = Int32.TryParse(elt2, out ch2);
                        if (isInt1 && isInt2)
                            Zadacha1.label.Text = MoreDigits(ch1, ch2).ToString();
                        else
                            Zadacha1.label.Text = "Неверные входные данные";
                    }
                    break;
                case 7:
                    {
                        double ch1, ch2;
                        bool isDouble1 = Double.TryParse(elt1, out ch1);
                        bool isDouble2 = Double.TryParse(elt2, out ch2);
                        if (isDouble1 && isDouble2)
                            Zadacha1.label.Text = CompareDecimalPlaces(ch1, ch2).ToString();
                        else
                            Zadacha1.label.Text = "Неверные входные данные";
                    }
                    break;
                case 8:
                case 9:
                    {
                        if (elt1.Contains(',') && elt2.Contains(','))
                        {
                            if (butNum == 8)
                                Zadacha1.label.Text = ArrayToString(MergeArraysUnic(elt1.Split(','), elt2.Split(',')));
                            else
                            if (butNum == 9)
                                Zadacha1.label.Text = ArrayToString(MergeArraysOne(elt1.Split(','), elt2.Split(',')));
                        }
                        else if (elt1.Equals(elt2) || elt2.Contains(elt1))
                            Zadacha1.label.Text = elt1;
                        else
                            Zadacha1.label.Text = "Неверные входные данные";
                    }
                    break;
                case 10:
                    {
                        if (elt1.Length == 1)
                            Zadacha1.label.Text = GetDigitValueFromChar(Convert.ToChar(elt1)).ToString();
                        else
                            Zadacha1.label.Text = "Неверные входные данные";
                    }
                    break;
                case 11:
                    {
                        int ch1, ch2, ch3;
                        bool isInt1 = Int32.TryParse(elt1, out ch1);
                        bool isInt2 = Int32.TryParse(elt2, out ch2);
                        bool isInt3 = Int32.TryParse(elt3, out ch3);
                        if (isInt1 && isInt2 && isInt3)
                        {
                            int[] a = new int[ch1];
                            Zadacha1.label.Text = ConvertToSeconds(ch1, ch2, ch3).ToString();
                        }
                        else
                            Zadacha1.label.Text = "Неверные входные данные";
                    }
                    break;
                case 12:
                    {
                        int ch1;
                        bool isInt1 = Int32.TryParse(elt1, out ch1);
                        if (isInt1)
                        {
                            int[] a = new int[ch1];
                            Zadacha1.label.Text = ArrayToString(FillArray(a));
                        }
                        else
                            Zadacha1.label.Text = "Неверные входные данные, необходимо указать размер массива";
                    }
                    break;
                case 13: 
                    {
                        int ch1;
                        bool isInt1 = Int32.TryParse(elt1, out ch1);
                        if (isInt1)
                        {
                            Zadacha1.label.Text = password_generator(ch1).ToString();
                        }
                        else
                            Zadacha1.label.Text = "Неверные входные данные, необходимо указать длину пароля";
                    } 
                    break;
                case 14: 
                    {
                        int ch = 0;
                        bool isCh = Int32.TryParse(elt1, out ch);

                        if (elt2.Contains(',') && isCh && elt2.Length > ch)
                            Zadacha1.label.Text = CopyArray(elt1.Split(','), elt2.Split(','), ch).ToString();
                        else if (elt2.Length == 1 && ch == 1)
                            Zadacha1.label.Text = elt1 + elt2;
                        else
                            Zadacha1.label.Text = "Неверные входные данные";
                    } 
                    break;
                case 15: 
                    {
                        Zadacha1.label.Text = GenerateEmail(); 
                    }
                    break;
                case 16:
                    {
                        double ch1, ch2;
                        bool isDouble1 = Double.TryParse(elt1, out ch1);
                        bool isDouble2 = Double.TryParse(elt2, out ch2);
                        if (isDouble1 && isDouble2)
                            Zadacha1.label.Text = ConvertRublesToDollars(ch1, ch2).ToString();
                        else
                            Zadacha1.label.Text = "Неверные входные данные";
                    }
                    break;
                case 17: 
                    {
                        Zadacha1.label.Text = WordCount(elt1).ToString();
                    } 
                    break;
                case 18: 
                    {
                        int ch;
                        bool isInt = Int32.TryParse(elt1, out ch);
                        if (isInt)
                            Zadacha1.label.Text = ConvertInt_8_16(ch).ToString();
                        else
                            Zadacha1.label.Text = "Неверные входные данные";
                    } 
                    break;
                case 19: 
                    {
                        int ch;
                        bool isInt = Int32.TryParse(elt2, out ch);
                        if (isInt)
                        {
                            Zadacha1.label.Text = ArrayToString(ResizeArray(elt1.Split(','),ch));
                        }
                        else
                            Zadacha1.label.Text = "Неверные входные данные, необходимо указать размер массива";
                    } 
                    break;
                case 20: 
                    {
                        if (elt1.Contains(','))
                        {
                            Zadacha1.label.Text = ArrayToString(GetUniqueValues(elt1.Split(',')));
                        }
                        else 
                            Zadacha1.label.Text = elt1;
                    } 
                    break;
            }
        }

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
        public int[] FillArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < (array.Count() - 1); i++)
            {
                array[i] = random.Next(-100, 100);
            }
            PrintArray(array);
            return array;
        }
        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Count() - 1; i++)
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
        public string ConvertInt_8_16(int number)
        {
            return "В восьмеричной системе: {}" + Convert.ToString(number, 8) +
                "\n В шестнадцатеричной системе: " + Convert.ToString(number, 16);
        }

        /*!
         * Задача 1.19
         * Написать функцию, которая увеличивает размерность массива на заданное количество единиц,
         * с сохранением старых значений
         */
        public T[] ResizeArray<T>(T[] array, int newSize)
        {
            T[] newArray = new T[array.Length + newSize];
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
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


        public static string ArrayToString<T>(T[] array)
        {
            string result = "";
            foreach (T item in array)
            {
                if (item != null)
                    result += item.ToString() + ", ";
                else
                    result += "0, ";
            }
            return result;
        }
    }
}
