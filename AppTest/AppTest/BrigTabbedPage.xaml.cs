using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Net;

namespace AppTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrigTabbedPage : TabbedPage
    {
        public BrigTabbedPage(int brig)
        {
            InitializeComponent();

            var client = new WebClient();
            var respons = client.DownloadString("http://192.168.1.194/WebTest/api/Задачи/" + Convert.ToString(brig));

            ListTask.ItemsSource = JsonConvert.DeserializeObject<List<Задачи>>(respons);

            respons = client.DownloadString("http://192.168.1.194/WebTest/api/Сотрудники/" + Convert.ToString(brig));

            ListEmpl.ItemsSource = JsonConvert.DeserializeObject<List<Сотрудники>>(respons);
        }

        private void AddTask_Clicked(object sender, EventArgs e)
        {

        }

        private void AddEmpl_Clicked(object sender, EventArgs e)
        {

        }
    }
}