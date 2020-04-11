using OAuthNativeFlow.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OAuthNativeFlow
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class Button
    {
        public string nom { get; set; }
        public string image { get; set; }
        public Button() { 
            }
    }
    public partial class ProfilePagee : ContentPage
    {
        List<Button> Buttons;
        public ProfilePagee()
        {

            InitializeComponent();

            if (Application.Current.Properties["ProfilePicture"] != null)
                AppUser.SetPhotoProfil(Application.Current.Properties["ProfilePicture"].ToString());

            if (Application.Current.Properties["FirstName"] != null)
                AppUser.SetUserName(Application.Current.Properties["FirstName"].ToString());

            if (Application.Current.Properties["EmailAddress"] != null)
                AppUser.SetEmail(Application.Current.Properties["EmailAddress"].ToString());

            App.Current.MainPage = MainView();

            PhotoDeProfil.Source = AppUser.GetPhotoProfil();

            Buttons = new List<Button>();
            Buttons.Add( new Button{ nom = "Theme" , image = "pencil.png" });
            Buttons.Add(new Button { nom = "Acount information" , image = "report.png" });
            Buttons.Add(new Button { nom = "About", image = "info.png" });
            ButtonListe.ItemsSource = Buttons;
            ButtonListe.ItemSelected += (sender, e) =>
            {
                if (ButtonListe.SelectedItem != null)
                {
                    Button item = ButtonListe.SelectedItem as Button;
                    if (item.nom == "Theme")
                    {
                        DisplayAlert("Theme", "Coming soon", "ok");
                        ButtonListe.SelectedItem = null;
                    }
                    else
                    {
                        DisplayAlert("Account informations", "Creation time : 10/04/2020", "ok");
                        ButtonListe.SelectedItem = null;
                    }
                }
            };

        }

        private Page MainView()
        {
            throw new NotImplementedException();
        }
    }
}