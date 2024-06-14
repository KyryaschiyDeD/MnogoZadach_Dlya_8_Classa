using Microsoft.Maui.Controls.Xaml;
using System.Collections.ObjectModel;
using System.Reflection;

namespace MnogoZadachDky8Classa.Param1;

public partial class Zadacha1 : ContentPage
{

    static string[] methodsNames = { "IsUpper", "IsDigit", "ToUpper", "Factorial", "Power", "MoreDigits", "CompareDecimalPlaces", "MergeArraysUnic", "MergeArraysOne", "GetDigitValueFromChar", "ConvertToSeconds", "FillArray", "PrintArray", "password_generator", "CopyArray", "GenerateEmail", "ConvertRublesToDollars", "WordCount", "ConvertInt_8_16", "ResizeArray", "GetUniqueValues" };


    public Zadacha1()
    {
        InitializeComponent();
        GenerateButtons();


    }

    private void GenerateButtons()
    {
        Grid grid = new Grid
        {
            RowDefinitions =
                {
                    new RowDefinition{ Height=new GridLength(30) },
                    new RowDefinition{ Height=new GridLength(1, GridUnitType.Star) },
                    new RowDefinition{ Height=new GridLength(2, GridUnitType.Star) }
                },
            ColumnDefinitions =
                {
                    new ColumnDefinition{Width = new GridLength(60)},
                    new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)}
                }
        };

        string[] namesStolb = { "", "Один аргумент", "Два аргумента", "Три аргумента" };
        string[] argument0 = { "15" };
        string[] argument1 = { "1", "2", "3", "4", "10", "13", "17", "18", "20" };
        string[] argument2 = { "5", "6", "7", "8", "9", "12", "16", "19"};
        string[] argument3 = { "11", "14" };

        List<string[]> arguments = new List<string[]>() { argument0, argument1, argument2, argument3 };

        int stolb = 0;
        foreach (string oneName in namesStolb)
        {
            Label nameOneStolb = new Label { FontSize = 18, Text = oneName };
            grid.Add(nameOneStolb, stolb, 0);
            stolb++;
        }

        stolb = 0;
        foreach (string[] countArgumentsElt in arguments)
        {
            
            if (stolb != 0)
            {
                Editor textEditor = new Editor { HeightRequest = 200, FontSize = 16, BackgroundColor = Colors.DarkGray };
                grid.Add(textEditor, stolb, 1);
            }
                
            StackLayout oneStackBut = new StackLayout();
            foreach (string exNumber in countArgumentsElt)
            {
                Button button = new Button { Text = exNumber, HorizontalOptions = LayoutOptions.Start };

                oneStackBut.Children.Add(button);
            }
            grid.Add(oneStackBut, stolb, 2);
            stolb++;
        }


        //Label label = new Label { Text = "///" };
        /*one zadach = new one();
        StackLayout stackLayout = new StackLayout();
        for (int i = 1; i <= 20; i++)
        {
            Button button = new Button { Text = i.ToString(), HorizontalOptions = LayoutOptions.Start };
            var method = typeof(one).GetMethod("ConvertInt_8_16");
            button.Clicked += (sender, e) => method.Invoke(zadach, new object[] { });

            stackLayout.Children.Add(button);
            //Content = stackLayout;
        }*/



        
        Content = grid;
    }
}