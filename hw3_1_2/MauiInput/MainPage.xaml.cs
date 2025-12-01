namespace MauiInput;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnSubmitClicked(object sender, EventArgs e)
	{
		if (int.TryParse(NumberEntry.Text, out int n))
			await DisplayAlert("Результат", $"Ви ввели число {n}", "OK");
		else
			await DisplayAlert("Помилка", "Введіть ціле число!", "OK");
	}
}