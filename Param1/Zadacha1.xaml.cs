using Microsoft.Maui.Controls.Xaml;
using System.Collections.ObjectModel;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace MnogoZadachDky8Classa.Param1;

public partial class Zadacha1 : ContentPage
{

    static string[] methodsNames = { "IsUpper", "IsDigit", "ToUpper", "Factorial", "Power", "MoreDigits", "CompareDecimalPlaces", "MergeArraysUnic", "MergeArraysOne", "GetDigitValueFromChar", "ConvertToSeconds", "FillArray", "PrintArray", "password_generator", "CopyArray", "GenerateEmail", "ConvertRublesToDollars", "WordCount", "ConvertInt_8_16", "ResizeArray", "GetUniqueValues" };

    public static Label label = new Label { Text = "" };

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
                    new RowDefinition{ Height=new GridLength(2, GridUnitType.Star) },
                    new RowDefinition{ Height=new GridLength(1, GridUnitType.Star) }
                },
            ColumnDefinitions =
                {
                    new ColumnDefinition{Width = new GridLength(60)},
                    new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)}
                }
        };
        
        Editor textEditor1 = new Editor { HeightRequest = 200, FontSize = 16, BackgroundColor = Colors.DarkGray };
        grid.Add(textEditor1, 1, 1);
        Editor textEditor2 = new Editor { HeightRequest = 200, FontSize = 16, BackgroundColor = Colors.DarkGray };
        grid.Add(textEditor2, 2, 1);
        Editor textEditor3 = new Editor { HeightRequest = 200, FontSize = 16, BackgroundColor = Colors.DarkGray };
        grid.Add(textEditor3, 3, 1);
        
        string[] namesStolb = { "", "Один аргумент", "Два аргумента", "Три аргумента" };
        string[] argument0 = { "15" };
        string[] argument1 = { "1", "2", "3", "4", "10", "12", "13", "17", "18", "20" };
        string[] argument2 = { "5", "6", "7", "8", "9", "16", "19"};
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
        oneCore zadach = new oneCore();
        var method = typeof(oneCore).GetMethod("GetValueJob");
        foreach (string[] countArgumentsElt in arguments)
        { 
            StackLayout oneStackBut = new StackLayout();
            foreach (string exNumber in countArgumentsElt)
            {
                Button button = new Button { Text = exNumber, HorizontalOptions = LayoutOptions.Start };
                button.Clicked += (sender, e) => method.Invoke(zadach, new object[] { Convert.ToInt32(exNumber), textEditor1.Text, textEditor2.Text, textEditor3.Text });

                oneStackBut.Children.Add(button);
            }
            grid.Add(oneStackBut, stolb, 2);
            stolb++;
        }

        grid.Add(label, 1,4);

        Content = grid;
    }

    

}