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

        public Legend SelectedLegend { get; set; }
        public LegendDetailsPage(Legend l)
        {
            InitializeComponent();

            SelectedLegend = l;
            this.BindingContext = this;
            //lblLegendDetails.Text = $"Overview of all {l.Name}'s details";
        }
    }
}