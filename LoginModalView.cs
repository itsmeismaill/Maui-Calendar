// LoginViewModel.cs
using Microsoft.Maui.Controls;
using System.ComponentModel;
using System.Windows.Input;

namespace Calendrier
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private AuthService authService;

        public LoginViewModel()
        {
            authService = new AuthService();
            LoginCommand = new Command(Login);
        }

        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                if (username != value)
                {
                    username = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Username)));
                }
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Password)));
                }
            }
        }

        public ICommand LoginCommand { get; }

        private async void Login()
        {
            bool isAuthenticated = authService.Authenticate(Username, Password);
            if (isAuthenticated)
            {
                // Navigate to main page (replace MainPage with your actual calendar page)
                await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
            }
            else
            {
                // Show error message or handle authentication failure
                await Application.Current.MainPage.DisplayAlert("Authentication Failed", "Invalid username or password", "OK");
            }
        }
    }
}
