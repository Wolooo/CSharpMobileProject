using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Legends.Data;

namespace Legends
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LegendDetailsPage : TabbedPage
    {
        private Dictionary<string, Legend> dicLegends;

        public Legend SelectedLegendName { get; set; }
        public Legend SelectedLegendTitle { get; set; }
        public LegendDetailsPage(Legend l)
        {
            InitializeComponent();

            GetLegendName(dicLegends, l);
            //lblLegendDetails.Text = $"Overview of all {l.Name}'s details";
        }

        public void GetLegendName(Dictionary<string, Legend> dic, Legend leg)
        {
            dic = LegendData.GetJsonData();

            foreach (var legend in dic)
            {
                if (legend.Key == leg.Name)
                {
                    SelectedLegendName = leg;
                    SelectedLegendTitle = leg;
                    this.BindingContext = this;
                }
            }
        }
    }
}