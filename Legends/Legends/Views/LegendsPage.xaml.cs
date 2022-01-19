using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Legends.Data;
using Legends.Helpers;

namespace Legends
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LegendsPage : ContentPage
    {
        private Dictionary<string, Legend> dictLegends;
        public LegendsPage()
        {
            InitializeComponent();

            dictLegends = LegendData.GetJsonData();
            
            LoadData(dictLegends);
        }

        public void LoadData(Dictionary<string, Legend> list)
        {
            foreach (var legend in list)
            {
                Image img = new Image
                {
                    Source = legend.Value.ImageUrl,
                    WidthRequest = 60,
                    HeightRequest = 60
                };

                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += (s, e) =>
                {
                    //Hoe geven we de naam door naar de details page + hoe hoe deserializen van json file
                    Navigation.PushAsync(new LegendDetailsPage(legend.Value));
                };

                img.GestureRecognizers.Add(tapGestureRecognizer);
                
                StackLayout flexItem = new StackLayout() { Margin = new Thickness(8,8,8,0), Padding = new Thickness(10,0,10,0) };
                flexItem.Children.Add(img);
                flexItem.Children.Add(new Label
                {
                    Text = legend.Value.Name,
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontAttributes = FontAttributes.Bold,
                    BackgroundColor = Color.FromHex("#555a43"),
                    TextColor = Color.FromHex("#a39149"),
                    FontSize = 12,

                });
                flexList.Children.Add(flexItem);
            }
        }
    }

    
}