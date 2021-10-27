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
        public LegendsPage()
        {
            InitializeComponent();

            List<Legend> ListLegends = new List<Legend>
            {
                new Legend{Name="Aatrox", ImageUrl="Aatrox.png"},
                new Legend{Name="Ahri", ImageUrl="Ahri.png"},
                new Legend{Name="Akali", ImageUrl="Akali.png"},
                new Legend{Name="Akshan", ImageUrl="Akshan.png"},
                new Legend{Name="Alistar", ImageUrl="Alistar.png"},
                new Legend{Name="Amumu", ImageUrl="Amumu.png"},
                new Legend{Name="Anivia", ImageUrl="Anivia.png"},
                new Legend{Name="Annie", ImageUrl="Annie.png"},
                new Legend{Name="Aphelios", ImageUrl="Aphelios.png"},
                new Legend{Name="Ashe", ImageUrl="Ashe.png"},
                new Legend{Name="AurelionSol", ImageUrl="AurelionSol.png"},
                new Legend{Name="Azir", ImageUrl="Azir.png"},
                new Legend{Name="Bard", ImageUrl="Bard.png"},
                new Legend{Name="Blitzcrank", ImageUrl="Blitzcrank.png"},
                new Legend{Name="Braum", ImageUrl="Braum.png"},
                new Legend{Name="Brand", ImageUrl="Brand.png"},
                new Legend{Name="Caitlyn", ImageUrl="Caitlyn.png"},
                new Legend{Name="Camille", ImageUrl="Camille.png"},
                new Legend{Name="Cassiopeia", ImageUrl="Cassiopeia.png"},
                new Legend{Name="Chogath", ImageUrl="Chogath.png"},
                new Legend{Name="Corki", ImageUrl="Corki.png"},
                new Legend{Name="Darius", ImageUrl="Darius.png"},
                new Legend{Name="Diana", ImageUrl="Diana.png"},
                new Legend{Name="Draven", ImageUrl="Draven.png"},
                new Legend{Name="DrMundo", ImageUrl="DrMundo.png"},
                new Legend{Name="Ekko", ImageUrl="Ekko.png"},
                new Legend{Name="Evelynn", ImageUrl="Evelynn.png"},
                new Legend{Name="Elise", ImageUrl="Elise.png"},
                new Legend{Name="Ezreal", ImageUrl="Ezreal.png"},
                new Legend{Name="Fiddlesticks", ImageUrl="Fiddlesticks.png"},
                new Legend{Name="Fiora", ImageUrl="Fiora.png"},
                new Legend{Name="Fizz", ImageUrl="Fizz.png"},
                new Legend{Name="Galio", ImageUrl="Galio.png"},
                new Legend{Name="Gangplank", ImageUrl="Gangplank.png"},
                new Legend{Name="Garen", ImageUrl="Garen.png"},
                new Legend{Name="Gnar", ImageUrl="Gnar.png"},
                new Legend{Name="Gragas", ImageUrl="Gragas.png"},
                new Legend{Name="Graves", ImageUrl="Graves.png"},
                new Legend{Name="Gwen", ImageUrl="Gwen.png"},
                new Legend{Name="Hecarim", ImageUrl="Hecarim.png"},
                new Legend{Name="Heimerdinger", ImageUrl="Heimerdinger.png"},
                new Legend{Name="Illaoi", ImageUrl="Illaoi.png"},
                new Legend{Name="Irelia", ImageUrl="Irelia.png"},
                new Legend{Name="Ivern", ImageUrl="Ivern.png"},
                new Legend{Name="Janna", ImageUrl="Janna.png"},
                new Legend{Name="JarvanIV", ImageUrl="JarvanIV.png"},
                new Legend{Name="Jax", ImageUrl="Jax.png"},
                new Legend{Name="Jayce", ImageUrl="Jayce.png"},
                new Legend{Name="Jhin", ImageUrl="Jhin.png"},
                new Legend{Name="Jinx", ImageUrl="Jinx.png"},
                new Legend{Name="Kaisa", ImageUrl="Kaisa.png"},
                new Legend{Name="Kalista", ImageUrl="Kalista.png"},
                new Legend{Name="Karma", ImageUrl="Karma.png"},
                new Legend{Name="Karthus", ImageUrl="Karthus.png"},
                new Legend{Name="Kassadin", ImageUrl="Kassadin.png"},
                new Legend{Name="Katarina", ImageUrl="Katarina.png"},
                new Legend{Name="Kayle", ImageUrl="Kayle.png"},
                new Legend{Name="Kayn", ImageUrl="Kayn.png"},
                new Legend{Name="Kennen", ImageUrl="Kennen.png"},
                new Legend{Name="Khazix", ImageUrl="Khazix.png"},
                new Legend{Name="Kindred", ImageUrl="Kindred.png"},
                new Legend{Name="Kled", ImageUrl="Kled.png"},
                new Legend{Name="KogMaw", ImageUrl="KogMaw.png"},
                new Legend{Name="Leblanc", ImageUrl="Leblanc.png"},
                new Legend{Name="LeeSin", ImageUrl="LeeSin.png"},
                new Legend{Name="Leona", ImageUrl="Leona.png"},
                new Legend{Name="Lillia", ImageUrl="Lillia.png"},
                new Legend{Name="Lissandra", ImageUrl="Lissandra.png"},
                new Legend{Name="Lucian", ImageUrl="Lucian.png"},
                new Legend{Name="Lulu", ImageUrl="Lulu.png"},
                new Legend{Name="Lux", ImageUrl="Lux.png"},
                new Legend{Name="Malphite", ImageUrl="Malphite.png"},
                new Legend{Name="Malzahar", ImageUrl="Malzahar.png"},
                new Legend{Name="Maokai", ImageUrl="Maokai.png"},
                new Legend{Name="MasterYi", ImageUrl="MasterYi.png"},
                new Legend{Name="MissFortune", ImageUrl="MissFortune.png"},
                new Legend{Name="MonkeyKing", ImageUrl="MonkeyKing.png"},
                new Legend{Name="Mordekaiser", ImageUrl="Mordekaiser.png"},
                new Legend{Name="Morgana", ImageUrl="Morgana.png"},
                new Legend{Name="Nami", ImageUrl="Nami.png"},
                new Legend{Name="Nasus", ImageUrl="Nasus.png"},
                new Legend{Name="Nautilus", ImageUrl="Nautilus.png"},
                new Legend{Name="Neeko", ImageUrl="Neeko.png"},
                new Legend{Name="Nidalee", ImageUrl="Nidalee.png"},
                new Legend{Name="Nocturne", ImageUrl="Nocturne.png"},
                new Legend{Name="Nunu", ImageUrl="Nunu.png"},
                new Legend{Name="Olaf", ImageUrl="Olaf.png"},
                new Legend{Name="Orianna", ImageUrl="Orianna.png"},
                new Legend{Name="Ornn", ImageUrl="Ornn.png"},
                new Legend{Name="Pantheon", ImageUrl="Pantheon.png"},
                new Legend{Name="Poppy", ImageUrl="Poppy.png"},
                new Legend{Name="Pyke", ImageUrl="Pyke.png"},
                new Legend{Name="Qiyana", ImageUrl="Qiyana.png"},
                new Legend{Name="Quinn", ImageUrl="Quinn.png"},
                new Legend{Name="Rakan", ImageUrl="Rakan.png"},
                new Legend{Name="Rammus", ImageUrl="Rammus.png"},
                new Legend{Name="RekSai", ImageUrl="RekSai.png"},
                new Legend{Name="Rell", ImageUrl="Rell.png"},
                new Legend{Name="Renekton", ImageUrl="Renekton.png"},
                new Legend{Name="Rengar", ImageUrl="Rengar.png"},
                new Legend{Name="Riven", ImageUrl="Riven.png"},
                new Legend{Name="Rumble", ImageUrl="Rumble.png"},
                new Legend{Name="Ryze", ImageUrl="Ryze.png"},
                new Legend{Name="Samira", ImageUrl="Samira.png"},
                new Legend{Name="Sejuani", ImageUrl="Sejuani.png"},
                new Legend{Name="Senna", ImageUrl="Senna.png"},
                new Legend{Name="Seraphine", ImageUrl="Seraphine.png"},
                new Legend{Name="Sett", ImageUrl="Sett.png"},
                new Legend{Name="Shaco", ImageUrl="Shaco.png"},
                new Legend{Name="Shen", ImageUrl="Shen.png"},
                new Legend{Name="Shyvana", ImageUrl="Shyvana.png"},
                new Legend{Name="Singed", ImageUrl="Singed.png"},
                new Legend{Name="Sion", ImageUrl="Sion.png"},
                new Legend{Name="Sivir", ImageUrl="Sivir.png"},
                new Legend{Name="Skarner", ImageUrl="Skarner.png"},
                new Legend{Name="Sona", ImageUrl="Sona.png"},
                new Legend{Name="Soraka", ImageUrl="Soraka.png"},
                new Legend{Name="Swain", ImageUrl="Swain.png"},
                new Legend{Name="Sylas", ImageUrl="Sylas.png"},
                new Legend{Name="Syndra", ImageUrl="Syndra.png"},
                new Legend{Name="TahmKench", ImageUrl="TahmKench.png"},
                new Legend{Name="Taliyah", ImageUrl="Taliyah.png"},
                new Legend{Name="Talon", ImageUrl="Talon.png"},
                new Legend{Name="Taric", ImageUrl="Taric.png"},
                new Legend{Name="Teemo", ImageUrl="Teemo.png"},
                new Legend{Name="Thresh", ImageUrl="Thresh.png"},
                new Legend{Name="Tristana", ImageUrl="Tristana.png"},
                new Legend{Name="Trundle", ImageUrl="Trundle.png"},
                new Legend{Name="Tryndamere", ImageUrl="Tryndamere.png"},
                new Legend{Name="TwistedFate", ImageUrl="TwistedFate.png"},
                new Legend{Name="Twitch", ImageUrl="Twitch.png"},
                new Legend{Name="Udyr", ImageUrl="Udyr.png"},
                new Legend{Name="Urgot", ImageUrl="Urgot.png"},
                new Legend{Name="Varus", ImageUrl="Varus.png"},
                new Legend{Name="Vayne", ImageUrl="Vayne.png"},
                new Legend{Name="Veigar", ImageUrl="Veigar.png"},
                new Legend{Name="Velkoz", ImageUrl="Velkoz.png"},
                new Legend{Name="Vex", ImageUrl="Vex.png"},
                new Legend{Name="Vi", ImageUrl="Vi.png"},
                new Legend{Name="Viego", ImageUrl="Viego.png"},
                new Legend{Name="Viktor", ImageUrl="Viktor.png"},
                new Legend{Name="Vladimir", ImageUrl="Vladimir.png"},
                new Legend{Name="Volibear", ImageUrl="Volibear.png"},
                new Legend{Name="Warwick", ImageUrl="Warwick.png"},
                new Legend{Name="Xayah", ImageUrl="Xayah.png"},
                new Legend{Name="Xerath", ImageUrl="Xerath.png"},
                new Legend{Name="XinZhao", ImageUrl="XinZhao.png"},
                new Legend{Name="Yasuo", ImageUrl="Yasuo.png"},
                new Legend{Name="Yone", ImageUrl="Yone.png"},
                new Legend{Name="Yorick", ImageUrl="Yorick.png"},
                new Legend{Name="Yuumi", ImageUrl="Yuumi.png"},
                new Legend{Name="Zac", ImageUrl="Zac.png"},
                new Legend{Name="Zed", ImageUrl="Zed.png"},
                new Legend{Name="Ziggs", ImageUrl="Ziggs.png"},
                new Legend{Name="Zilean", ImageUrl="Zilean.png"},
                new Legend{Name="Zoe", ImageUrl="Zoe.png"},
                new Legend{Name="Zyra", ImageUrl="Zyra.png"}
            };

            LoadData(ListLegends);
        }

        public void LoadData(List<Legend> list)
        {
            foreach (var legend in list)
            {
                Image img = new Image
                {
                    Source = legend.ImageUrl,
                    WidthRequest = 100,
                    HeightRequest = 100
                };

                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += (s, e) =>
                {
                    //Hoe geven we de naam door naar de details page + hoe hoe deserializen van json file
                    Navigation.PushAsync(new LegendDetailsPage(legend));
                };

                img.GestureRecognizers.Add(tapGestureRecognizer);
                
                StackLayout flexItem = new StackLayout() { Margin = new Thickness(10,10,10,0), Padding = new Thickness(10,0,10,0) };
                flexItem.Children.Add(img);
                flexItem.Children.Add(new Label
                {
                    Text = legend.Name,
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.White,
                    //TextColor = Color.White,
                    FontSize = 15
                    
                });
                flexList.Children.Add(flexItem);
            }
        }
    }

    
}