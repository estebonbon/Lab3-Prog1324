using System.Windows.Input;

namespace Lab3.Views
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this; // Im not sure if thats correct for second page or not
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        public ICommand LocCommand => new Command<string>(async (pageLoc) => await Shell.Current.GoToAsync(pageLoc));

        private async void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            await DisplayAlert("Vote Alert", "Make sure to Vote", "OK");
        }

       private async void OnImageTapped(object? sender, EventArgs args)
        {
            mediaSound.Play(); //Makes the sound from the media toolkit play
        }

        private void ContentPage_Unloaded(object sender, EventArgs e)
        {
            mediaSound.Handler?.DisconnectHandler(); // Disconects the sound from playing??
        }
    }
}
