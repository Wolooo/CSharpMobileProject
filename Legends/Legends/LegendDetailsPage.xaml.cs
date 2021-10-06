using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Legends
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LegendDetailsPage : TabbedPage
    {
        public LegendDetailsPage(string name)
        {
            InitializeComponent();

            lblLegendDetails.Text = $"Overview of all {name}'s details";
        }
    }
}