using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TH3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Bai1 : ContentPage
    {
        public List<Country> dsQG;
        public void Init() 
        {
            dsQG = new List<Country>();

            Country VN = new Country("Việt Nam");
            VN.Description = "Viet Nam";
            VN.Add(new City { CityName = "Hồ Chí Minh", CountryName = VN.CountryName, ImgSrc = "hcm.jpg" });
            VN.Add(new City { CityName = "Hà Nội", CountryName = VN.CountryName, ImgSrc = "hn.jpg" });
            VN.Add(new City { CityName = "Đà Nẵng", CountryName = VN.CountryName, ImgSrc = "dn.jpg" });
            VN.Add(new City { CityName = "Đà Lạt", CountryName = VN.CountryName, ImgSrc = "dl.jpg" });

            dsQG.Add(VN);

            Country USA = new Country("USA") ;
            USA.Description = "United State America";
            USA.Add(new City { CityName = "New York", CountryName = VN.CountryName, ImgSrc = "ny.jpg" });
            USA.Add(new City { CityName = "Chicago", CountryName = VN.CountryName, ImgSrc = "ccg.jpg" });
            USA.Add(new City { CityName = "Washington D.C", CountryName = VN.CountryName, ImgSrc = "wst.jpg" });
            USA.Add(new City { CityName = "Las Vegas", CountryName = VN.CountryName, ImgSrc = "lv.jpg" });

            dsQG.Add(USA);
        }
        public Bai1()
        {
            InitializeComponent();
            Init();
            dsQuocGia.ItemsSource = dsQG;
        }

        private void dsQuocGia_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}