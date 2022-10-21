using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Bai1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai1());
        }

        private void Bai2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai2());
        }

        private void Bai3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai3());
        }

        private void Bai4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai4());
        }

        private void Bai5_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai5());
        }
    }
}
