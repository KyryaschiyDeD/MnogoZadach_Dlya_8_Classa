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
}