using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnogoZadachDky8Classa.Param2
{
    internal class TwoCore
    {
        public CollectionView Num1()
        {
            CollectionView collectionView = new CollectionView();
            collectionView.ItemsSource = Zadacha2.students;

            collectionView.ItemTemplate = new DataTemplate(() =>
            {
                var nameLabel = new Label { FontSize = 20, TextColor = Colors.White, Margin = 10 };
                nameLabel.SetBinding(Label.TextProperty, "getFIO");

                var ageLabel = new Label();
                ageLabel.SetBinding(Label.TextProperty, new Binding { Path = "birthday", StringFormat = "Дата рождения: {0}" });

                return new StackLayout
                {
                    Children = { nameLabel, ageLabel },
                    Margin = new Thickness(15, 10)
                };
            });

            clearColumn();
            Zadacha2.grid.Add(collectionView, 1, 0);
            return collectionView;
        }
        public CollectionView Num2()
        {
            CollectionView collectionView = new CollectionView();
            collectionView.ItemsSource = Zadacha2.students;

            collectionView.ItemTemplate = new DataTemplate(() =>
            {
                var nameLabel = new Label { FontSize = 20, TextColor = Colors.White, Margin = 10 };
                nameLabel.SetBinding(Label.TextProperty, new Binding { Path = "getFIO", StringFormat = "Студент: {0}" });

                var ageLabel = new Label();
                ageLabel.SetBinding(Label.TextProperty, new Binding { Path = "GetTeachers", StringFormat = "Преподаватели: {0}" });

                return new StackLayout
                {
                    Children = { nameLabel, ageLabel },
                    Margin = new Thickness(15, 10)
                };
            });

            clearColumn();
            Zadacha2.grid.Add(collectionView, 1, 0);
            return collectionView;
        }
        public CollectionView Num3()
        {
            CollectionView collectionView = new CollectionView();
            collectionView.ItemsSource = Zadacha2.students;

            collectionView.ItemTemplate = new DataTemplate(() =>
            {
                var nameLabel = new Label { FontSize = 20, TextColor = Colors.White, Margin = 10 };
                nameLabel.SetBinding(Label.TextProperty, new Binding { Path = "getFIO", StringFormat = "Студент: {0}" });

                var ageLabel = new Label();
                ageLabel.SetBinding(Label.TextProperty, new Binding { Path = "_checkNumAndSub"});

                return new StackLayout
                {
                    Children = { nameLabel, ageLabel },
                    Margin = new Thickness(15, 10)
                };
            });

            clearColumn();
            Zadacha2.grid.Add(collectionView, 1, 0);
            return collectionView;
        }
        public CollectionView Num4(int n = 20)
        {
            CollectionView collectionView = new CollectionView();
            collectionView.ItemsSource = Zadacha2.students.Where(student => student.age < n).ToList();

            collectionView.ItemTemplate = new DataTemplate(() =>
            {
                var nameLabel = new Label { FontSize = 20, TextColor = Colors.White, Margin = 10 };
                nameLabel.SetBinding(Label.TextProperty, "getFIO");

                var ageLabel = new Label();
                ageLabel.SetBinding(Label.TextProperty, new Binding { Path = "birthdayStr", StringFormat = "Дата рождения: {0}" });

                var birthdayLabel = new Label();
                birthdayLabel.SetBinding(Label.TextProperty, new Binding { Path = "age", StringFormat = "Возраст: {0}" });

            
                return new StackLayout
                {
                    Children = { nameLabel, ageLabel, birthdayLabel },
                    Margin = new Thickness(15, 10)
                };
            });

            clearColumn();
            Zadacha2.grid.Add(collectionView, 1, 0);
            return collectionView;
        }
        public CollectionView Num5()
        {
            CollectionView collectionView = new CollectionView();
            collectionView.ItemsSource = Zadacha2.students.Where(student => student.getSrBall == 5).ToList();

            collectionView.ItemTemplate = new DataTemplate(() =>
            {
                var nameLabel = new Label { FontSize = 20, TextColor = Colors.White, Margin = 10 };
                nameLabel.SetBinding(Label.TextProperty, "getFIO");

                return new StackLayout
                {
                    Children = { nameLabel },
                    Margin = new Thickness(15, 10)
                };
            });

            clearColumn();
            Zadacha2.grid.Add(collectionView, 1, 0);
            return collectionView;
        }
        public CollectionView Num6()
        {
            CollectionView collectionView = new CollectionView();
            collectionView.ItemsSource = Zadacha2.students.Where(student => student.GetSubjects().Any(subject => subject.CheckNumber <= 2));

            collectionView.ItemTemplate = new DataTemplate(() =>
            {
                var nameLabel = new Label { FontSize = 20, TextColor = Colors.White, Margin = 10 };
                nameLabel.SetBinding(Label.TextProperty, "getFIO");

                var subNum = new Label();
                subNum.SetBinding(Label.TextProperty, new Binding { Path = "_checkNumAndSub" });

                return new StackLayout
                {
                    Children = { nameLabel, subNum },
                    Margin = new Thickness(15, 10)
                };
            });

            clearColumn();
            Zadacha2.grid.Add(collectionView, 1, 0);
            return collectionView;
        }
        public CollectionView Num7()
        {
            List<string> teachersWithExcellentMarks = new List<string>();

            var excellentTeachers = from student in Zadacha2.students
                                    where student._subjects.Any(subject => subject.CheckNumber == 5)
                                    select student;

            foreach (Student student in excellentTeachers)
            {
                foreach (Subjects subject in student._subjects)
                {
                    if (subject.CheckNumber == 5) 
                    {
                        teachersWithExcellentMarks.Add(subject._teacherName);
                    }
                }
            }


            CollectionView collectionView = new CollectionView();
            collectionView.ItemsSource = teachersWithExcellentMarks;

            clearColumn();
            Zadacha2.grid.Add(collectionView, 1, 0);
            return collectionView;
        }
        public CollectionView Num8()
        {
            CollectionView collectionView = new CollectionView();
            collectionView.ItemsSource = Zadacha2.students;

            collectionView.ItemTemplate = new DataTemplate(() =>
            {
                var nameLabel = new Label { FontSize = 20, TextColor = Colors.White, Margin = 10 };
                nameLabel.SetBinding(Label.TextProperty, new Binding { Path = "getFIO", StringFormat = "Студент: {0}" });

                var srLabel = new Label();
                srLabel.SetBinding(Label.TextProperty, new Binding { Path = "getSrBall", StringFormat = "Средняя: {0}" });

                return new StackLayout
                {
                    Children = { nameLabel, srLabel },
                    Margin = new Thickness(15, 10)
                };
            });

            
            Zadacha2.grid.Add(collectionView, 1, 0);
            return collectionView;
        }
        public CollectionView Num9()
        {
            CollectionView collectionView = new CollectionView();
            collectionView.ItemsSource = Zadacha2.students.OrderBy(student => student.birthday);

            collectionView.ItemTemplate = new DataTemplate(() =>
            {
                var nameLabel = new Label { FontSize = 20, TextColor = Colors.White, Margin = 10 };
                nameLabel.SetBinding(Label.TextProperty, "getFIO");

                var ageLabel = new Label();
                ageLabel.SetBinding(Label.TextProperty, new Binding { Path = "birthdayStr", StringFormat = "Дата рождения: {0}" });

                return new StackLayout
                {
                    Children = { nameLabel, ageLabel },
                    Margin = new Thickness(15, 10)
                };
            });

            clearColumn();
            Zadacha2.grid.Add(collectionView, 1, 0);
            return collectionView;
        }

        private void clearColumn()
        {
            Zadacha2.grid.ColumnDefinitions.RemoveAt(1);
            Zadacha2.grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(5, GridUnitType.Star) });
        }

    }
}
