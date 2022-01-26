using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Legends.Data;
using Legends.ViewModel;
using Legends.Models;

namespace Legends
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LegendDetailsPage : TabbedPage
    {
        private Dictionary<string, Legend> dicLegends;

        //public Legend SelectedLegendName { get; set; }
        //public Legend SelectedLegendTitle { get; set; }
        public LegendDetailsPage(Legend legend)
        {
            InitializeComponent();

            dicLegends = LegendData.GetJsonData();

            GetLegendName(dicLegends, legend);
            //lblLegendDetails.Text = $"Overview of all {l.Name}'s details";
        }

        public void GetLegendName(Dictionary<string, Legend> dic, Legend leg)
        {
            foreach (var legend in dic)
            {
                if (leg.Name == legend.Value.Name)
                {
                    LegendStatsViewModel model = new LegendStatsViewModel
                    {
                        LegendInfo = leg,
                        LegendAbilities = leg,
                        LegendLore = leg
                    };
                    this.BindingContext = model;
                }
            }
        }
    }
}