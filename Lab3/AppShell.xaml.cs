using Lab3.Views;

namespace Lab3
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //For navigation purposes register the second page
            Routing.RegisterRoute(nameof(SecondPage), typeof(SecondPage));
        }
    }
}
