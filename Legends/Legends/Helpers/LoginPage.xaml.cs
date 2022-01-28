using Legends.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Legends.Helpers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbPath);
            var query = db.Table<RegUserTable>().Where(u => u.UserName.Equals(EntryUser.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();

            if(query != null)
            {
                RegUserTable._Username = EntryUser.Text;
                await Navigation.PushModalAsync(new MainPage());
            } 
            else
            {
                var result = await this.DisplayAlert("Error", "Failed username and Password", "Yes", "Cancel");
                if (result)
                {
                    await Navigation.PushModalAsync(new LoginPage());
                }
                else
                {
                    await Navigation.PushModalAsync(new LoginPage());
                }
            }
        }

        private async void BtnRegister_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegistrationPage());
        }
    }
}