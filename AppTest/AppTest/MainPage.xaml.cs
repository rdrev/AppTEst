using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace AppTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var client = new WebClient();
            var respons = client.DownloadString("http://192.168.1.194/WebTest/api/Бригады");

            ListBri.ItemsSource = JsonConvert.DeserializeObject<List<Бригады>>(respons);
        }

        private void ListBri_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new BrigTabbedPage((ListBri.SelectedItem as Бригады).КодБригады));
        }
    }
}
