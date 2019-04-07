using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BGM;

namespace BGM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            RestService restService = new RestService();

            restService.getInventory();
            label.Text = restService.token;
        }
    }
}
