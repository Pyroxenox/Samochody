using Baza_Samochodow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Baza_Samochodow.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            labelUsername.TextColor = Constants.MainTextColor;
            entryUsername.PlaceholderColor = Constants.MainTextColor;
            entryPassword.PlaceholderColor = Constants.MainTextColor;

            entryUsername.Completed += (s, e) => entryPassword.Focus();
            entryPassword.Completed += (s, e) => SignIn(s, e);
        }

        async void SignIn(object sender, EventArgs e)
        {
            User user = new User(entryUsername.Text, entryPassword.Text);
            if (user.CheckInformation())
            {
                    var result = await App.RestService.Login(user);
                    if (result.access_token != null)
                    {
                        App.UserDatabase.SaveUser(user);
                        await DisplayAlert("Login", "Logowanie udane", "OK");
                    App.Current.MainPage = new MainPage();
                    }
                    else
                    {
                        await DisplayAlert("Login", "Logowanie nieudane, błędna nazwa użytkownika lub hasło.", "OK");
                    }
            }

        }

    }
}