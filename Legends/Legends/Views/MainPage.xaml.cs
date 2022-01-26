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
using Legends.Helpers;

namespace Legends
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            flyout.listview.ItemSelected += OnSelectedItem;
        }

        private void OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as FlyoutItemPage;
            if (item!=null)
            {
                var page = new NavigationPage((Page)Activator.CreateInstance(item.TargetPage));
                page.BarBackground = Color.FromHex("#112120");
                Detail = page;
                flyout.listview.SelectedItem = null;
                IsPresented = false;
            }
        }        
    }
}
