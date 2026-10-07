namespace Lab3.Views;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

    private void Play_Clicked(object sender, EventArgs e)
    {
        AdeleVideo.Play();
    }

    private void Pause_Clicked(object sender, EventArgs e)
    {
        AdeleVideo.Pause();
    }
}