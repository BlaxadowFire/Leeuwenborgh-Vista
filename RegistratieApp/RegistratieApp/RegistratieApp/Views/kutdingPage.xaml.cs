using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RegistratieApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class kutdingPage : ContentPage
    {
        public kutdingPage()
        {
            InitializeComponent();
            iWantToDie.Text = getStuff().GetAwaiter().GetResult();
        }
        public async Task<string> getStuff()
        {
            string response = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                var httpResponseMessage = client.GetAsync(new Uri("https://jsonplaceholder.typicode.com/posts/1")).GetAwaiter().GetResult();
                response = await httpResponseMessage.Content.ReadAsStringAsync();
            }
            return response;
        }
    }
}