using Microsoft.Maui.Controls;
using MnogoZadachDky8Classa.Param1;
using System;
using Windows.UI;

namespace MnogoZadachDky8Classa.Param2;

public partial class Zadacha2 : ContentPage
{
    public static List<Student> students = new List<Student>();

    public static Grid grid = new Grid
    {
        ColumnDefinitions =
                {
                    new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width = new GridLength(5, GridUnitType.Star)}
                }
    };

    public Zadacha2()
	{
		InitializeComponent();
        generateData();

        List<string> Metods = new List<string>() { "Num1", "Num2", "Num3", "Num4", "Num5", "Num6", "Num7", "Num8", "Num9" };
        
        StackLayout stack = new StackLayout();
        TwoCore zadach = new TwoCore();
        //int num = 1;
        
        foreach (string oneMethod in Metods)
        {
            var method = typeof(TwoCore).GetMethod(oneMethod);
            Button button = new Button { Text = "Задача # " + oneMethod.Last().ToString(), HorizontalOptions = LayoutOptions.Start };
            button.Clicked += (sender, e) => method.Invoke(zadach, new object[] {  });

            stack.Add(button);
            //num++;
        }
        grid.Add(stack, 0, 0);
        Content = grid;
    }

    private void generateData()
    {
        List<string> names = new List<string>() {
 "Александр", "Алексей", "Андрей", "Антон", "Артём", "Борис", "Вадим", "Виктор", "Владимир", "Владислав", "Георгий", "Григорий", "Денис", "Дмитрий", "Евгений", "Иван", "Игорь", "Илья", "Кирилл", "Константин", "Леонид", "Максим", "Михаил", "Николай", "Олег", "Павел", "Пётр", "Роман", "Сергей", "Тимофей", "Фёдор", "Юрий", "Ярослав"
};
        List<string> lastNames = new List<string>() {
 "Иванов", "Петров", "Сидоров", "Васильев", "Попов", "Смирнов", "Кузнецов", "Соколов", "Михайлов", "Новиков", "Федоров", "Морозов", "Волков", "Зайцев", "Панов", "Козлов", "Степанов", "Исаев", "Белов", "Рогов", "Соловьев", "Серов", "Краснова", "Савин", "Андреев", "Ковалев", "Дерябин", "Крюков", "Григорьев", "Лазарев", "Лебедев", "Тюрин"
};
        List<string> patronymics = new List<string>() {
 "Максимович", "Михайлович", "Иванович", "Александрович", "Владимирович", "Николаевич", "Сергеевич", "Дмитриевич", "Андреевич", "Юрьевич", "Валерьевич", "Витальевич"
 };

        List<string> schoolSubjects = new List<string>() {
 "Математика", "Русский язык", "История", "Физика", "Химия", "Биология", "География"
};
        Random random = new Random();
        List<string> prepod = new List<string>();
        for (int i = 0; i < 7; i++)
        {
            int nameIndex = random.Next(0, names.Count);
            string firstName = names[nameIndex];

            int lastNameIndex = random.Next(0, lastNames.Count);
            string lastName = lastNames[lastNameIndex];

            int lastPatronymicsIndex = random.Next(0, patronymics.Count);
            string patronymic = patronymics[lastPatronymicsIndex];

            prepod.Add(lastNames[lastNameIndex] + " " + names[nameIndex] + " " + patronymics[lastPatronymicsIndex]);
        }


        for (int i = 0; i < 60; i++)
        {
            int nameIndex = random.Next(0, names.Count);
            string firstName = names[nameIndex];

            int lastNameIndex = random.Next(0, lastNames.Count);
            string lastName = lastNames[lastNameIndex];

            int lastPatronymicsIndex = random.Next(0, patronymics.Count);
            string patronymic = patronymics[lastPatronymicsIndex];

            int year = 0;
            int month = 0;
            int day = 0;

            while (!IsValidDate(year, month, day))
            {
                year = random.Next(2000, 2009);
                month = random.Next(1, 13);
                day = random.Next(1, 31);
            }

            DateTime birthday = new DateTime(year, month, day);

            List<Subjects> subjects = new List<Subjects>();

            int subCount = random.Next(3, 6);
            for (int j = 0; j < subCount - 1; j++)
            {
                int subjectIndex = random.Next(0, schoolSubjects.Count);

                year = 9999999;

                while (!IsValidDate(year, month, day))
                {
                    year = random.Next(2020, 2025);
                    month = random.Next(1, 13);
                    day = random.Next(1, 31);
                }

                DateTime timeEx = new DateTime(year, month, day);

                subjects.Add(new Subjects(schoolSubjects[subjectIndex], random.Next(1, 6), timeEx, prepod[subjectIndex]));
            }

            students.Add(new Student(firstName, lastName, patronymic, birthday, subjects));
        }
    }

    public static bool IsValidDate(int year, int month, int day)
    {
        if (year < 1753 || year > 9999) // Проверка на допустимость года
        {
            return false;
        }

        if (month < 1 || month > 12) // Проверка на допустимость месяца
        {
            return false;
        }

        if (day < 1 || day > GetDaysInMonth(year, month)) // Проверка на допустимость дня
        {
            return false;
        }

        return true;
    }

    private static int GetDaysInMonth(int year, int month)
    {
        switch (month)
        {
            case 4:
            case 6:
            case 9:
            case 11:
                return 30;
            case 2:
                if (IsLeapYear(year))
                {
                    return 29;
                }
                return 28;
            default:
                return 31;
        }
    }

    private static bool IsLeapYear(int year)
    {
        return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
    }
}