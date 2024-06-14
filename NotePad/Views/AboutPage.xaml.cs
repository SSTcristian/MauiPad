namespace NotePad.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}


    private async void btnAbout_Clicked(object sender, EventArgs e)
    {
		if (BindingContext is Models.About about)
		{
			await Launcher.Default.OpenAsync(about.MoreInfoURL);
		}
    }
}