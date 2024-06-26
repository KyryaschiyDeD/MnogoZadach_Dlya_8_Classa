using Microsoft.Maui.Controls;
using System;

namespace MnogoZadachDky8Classa.Param2;

public partial class Zadacha2 : ContentPage
{
    List<Student> students = new List<Student>();
    public Zadacha2()
	{
		InitializeComponent();

        List<string> names = new List<string>() {
 "���������", "�������", "������", "�����", "����", "�����", "�����", "������", "��������", "���������", "�������", "��������", "�����", "�������", "�������", "����", "�����", "����", "������", "����������", "������", "������", "������", "�������", "����", "�����", "ϸ��", "�����", "������", "�������", "Ը���", "����", "�������"
};
        List<string> lastNames = new List<string>() {
 "������", "������", "�������", "��������", "�����", "�������", "��������", "�������", "��������", "�������", "�������", "�������", "������", "������", "�����", "������", "��������", "�����", "�����", "�����", "��������", "�����", "��������", "�����", "�������", "�������", "�������", "������", "���������", "�������", "�������", "�����"
};
        List<string> patronymics = new List<string>() {
 "����������", "����������", "��������", "�������������", "������������", "����������", "���������", "����������", "���������", "�������", "����������", "����������"
 };

        List<string> schoolSubjects = new List<string>() {
 "����������", "������� ����", "�������", "������", "�����", "��������", "���������"
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
            for (int j = 0;  j < subCount-1; j++)
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
        Num4(19);
    }

    public void Num1()
    {
        CollectionView collectionView = new CollectionView();
        collectionView.ItemsSource = students;

        collectionView.ItemTemplate = new DataTemplate(() =>
        {
            var nameLabel = new Label { FontSize = 20, TextColor = Colors.White, Margin = 10 };
            nameLabel.SetBinding(Label.TextProperty, "getFIO");

            var ageLabel = new Label();
            ageLabel.SetBinding(Label.TextProperty, new Binding { Path = "birthday", StringFormat = "���� ��������: {0}" });

            return new StackLayout
            {
                Children = { nameLabel, ageLabel },
                Margin = new Thickness(15, 10)
            };
        });

        Content = collectionView;
    }
    public void Num2()
    {
        CollectionView collectionView = new CollectionView();
        collectionView.ItemsSource = students;

        collectionView.ItemTemplate = new DataTemplate(() =>
        {
            var nameLabel = new Label { FontSize = 20, TextColor = Colors.White, Margin = 10 };
            nameLabel.SetBinding(Label.TextProperty, new Binding { Path = "getFIO", StringFormat = "�������: {0}" });

            var ageLabel = new Label();
            ageLabel.SetBinding(Label.TextProperty, new Binding { Path = "GetTeachers", StringFormat = "�������������: {0}" });

            return new StackLayout
            {
                Children = { nameLabel, ageLabel },
                Margin = new Thickness(15, 10)
            };
        });

        Content = collectionView;
    }
    public void Num3()
    {
        CollectionView collectionView = new CollectionView();
        collectionView.ItemsSource = students;

        collectionView.ItemTemplate = new DataTemplate(() =>
        {
            var nameLabel = new Label { FontSize = 20, TextColor = Colors.White, Margin = 10 };
            nameLabel.SetBinding(Label.TextProperty, new Binding { Path = "getFIO", StringFormat = "�������: {0}" });

            var ageLabel = new Label();
            ageLabel.SetBinding(Label.TextProperty, new Binding { Path = "_checkNumAndSub"});

            return new StackLayout
            {
                Children = { nameLabel, ageLabel },
                Margin = new Thickness(15, 10)
            };
        });

        Content = collectionView;
    }
    public void Num4(int n)
    {
        CollectionView collectionView = new CollectionView();
        collectionView.ItemsSource = students.Where(student => student.age > n).ToList();

        collectionView.ItemTemplate = new DataTemplate(() =>
        {
            var nameLabel = new Label { FontSize = 20, TextColor = Colors.White, Margin = 10 };
            nameLabel.SetBinding(Label.TextProperty, "getFIO");

            var ageLabel = new Label();
            ageLabel.SetBinding(Label.TextProperty, new Binding { Path = "birthday", StringFormat = "���� ��������: {0}" });

            return new StackLayout
            {
                Children = { nameLabel, ageLabel },
                Margin = new Thickness(15, 10)
            };
        });

        Content = collectionView;
    }

    public static bool IsValidDate(int year, int month, int day)
    {
        if (year < 1753 || year > 9999) // �������� �� ������������ ����
        {
            return false;
        }

        if (month < 1 || month > 12) // �������� �� ������������ ������
        {
            return false;
        }

        if (day < 1 || day > GetDaysInMonth(year, month)) // �������� �� ������������ ���
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