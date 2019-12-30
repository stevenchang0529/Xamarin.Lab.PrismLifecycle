using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.Lab.PrismLifecycle.Views
{
    public partial class MainPage : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }



        public MainPage()
        {
            InitializeComponent();
        }


    }
}