using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TH2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bai1 : ContentPage
    {
        public string[] dsNganh = new string[]
            {
                "Công nghệ thông tin",
                "Khoa học dữ liệu",
            };
        public Bai1()
        {
            
            InitializeComponent();
            NganhView.ItemsSource = dsNganh;

        }
    }
}