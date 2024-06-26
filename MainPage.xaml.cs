using System.Security.AccessControl;
using MnogoZadachDky8Classa;
using MnogoZadachDky8Classa.Param1;
using MnogoZadachDky8Classa.Param2;

namespace MnogoZadachDky8Classa;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

        Button toZadacha1PageBtn = new Button
        {
            Text = "1 Часть",
            HorizontalOptions = LayoutOptions.Start
        };
        toZadacha1PageBtn.Clicked += ToOnePage;

        Button toZadacha2PageBtn = new Button
        {
            Text = "2 Часть",
            HorizontalOptions = LayoutOptions.Start
        };
        toZadacha2PageBtn.Clicked += ToTwoPage;

        Content = new StackLayout { Children = { toZadacha1PageBtn, toZadacha2PageBtn } };
    }

    private async void ToTwoPage(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new Zadacha2());
    }
    private async void ToOnePage(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new Zadacha1());
    }

}

