namespace MnogoZadachDky8Classa.Param1;

public partial class Zadacha1 : ContentPage
{

    public Zadacha1()
    {
        InitializeComponent();
        createBackButton();
    }

    private void createBackButton()
    {
        Button backButton = new Button { Text = "Назад", HorizontalOptions = LayoutOptions.Start };
        Label label = new Label { Text = "Задачи.... Задачи...." };
        backButton.Clicked += async (o, e) => await Navigation.PopAsync();
        Content = new StackLayout { Children = { label, backButton } };
    }

    /*!
     * Задача 1.1
     * Напишите функцию bool IsUpper(char), которая определяет, является ли входной символ 
     * заглавной буквой латинского алфавита, без использования стандартной библиотеки.
     */
    private bool IsUpper(char symbol)
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
    private bool IsDigit(char symbol)
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
    private char ToUpper(char symbol)
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
    private long Factorial(int n)
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
    private double Power(double a, int n)
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
    private int MoreDigits(int num1, int num2)
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
    private int CompareDecimalPlaces(double num1, double num2)
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
    private int[] MergeArraysUnic(int[] array1, int[] array2)
    {
        return array1.Union(array2).ToArray();
    }

    /*!
     * Задача 1.9
     * Написать функцию, которая объединяет два одномерных массива в один, 
     * состоящих только из элементов входящих в первый массив
     */
    private int[] MergeArraysOne(int[] array1, int[] array2)
    {
        int[] result = new int[array1.Length + array2.Length];

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
    private int GetDigitValueFromChar(char myChar)
    {
        int digitValue = 0;

        if (char.IsDigit(myChar))
        {
            digitValue = myChar - '0';
        }

        return digitValue;
    }
}