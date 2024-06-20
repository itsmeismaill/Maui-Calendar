using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Application = Microsoft.Maui.Controls.Application;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace Calendrier
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new RegistrationPage());
        }
    }
}
