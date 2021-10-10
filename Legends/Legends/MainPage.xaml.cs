using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Legends.Data;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace Legends
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            GetJsonData();
        }

        private async void LegendsPage_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new LegendsPage());
        }

        public void GetJsonData()
        {
            string jsonFileName = "legends.json";
            ResponseModel legendList = new ResponseModel();
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;

            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");

            using (StreamReader reader = new StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();

                legendList = JsonConvert.DeserializeObject<ResponseModel>(jsonString);
            }
            //listviewChampions.ItemsSource = legendList.Data;
        }
    }
}
