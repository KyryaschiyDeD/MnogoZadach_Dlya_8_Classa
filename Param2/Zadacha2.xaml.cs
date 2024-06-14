namespace MnogoZadachDky8Classa.Param2;

public partial class Zadacha2 : ContentPage
{
	public Zadacha2()
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
}