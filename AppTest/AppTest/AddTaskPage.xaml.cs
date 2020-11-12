using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;

namespace AppTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTaskPage : ContentPage
    {
        public AddTaskPage()
        {
            InitializeComponent();

            var client = new WebClient();
            var respons = client.DownloadString("http://192.168.1.194/WebTest/api/Бригады");

            brig.ItemsSource = JsonConvert.DeserializeObject<List<Бригады>>(respons);
        }

        private void BtnVxod_Clicked(object sender, EventArgs e)
        {

        }

        private void Cle_Clicked(object sender, EventArgs e)
        {

        }
    }
}