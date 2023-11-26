namespace Test.Views;

public partial class Acerca : ContentPage
{
	public Acerca()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}