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
    public partial class Bai3 : ContentPage
    {
        public List<Country> nationList;
        public void NationInit()
        {
            nationList = new List<Country>();
            Country All = new Country("All");

            nationList.Add(All);

            Country VN = new Country("Việt Nam");
            VN.Description = "Viet Nam";
            VN.Add(new City { CityName = "Hồ Chí Minh", CountryName = VN.CountryName, ImgSrc = "hcm.jpg" });
            VN.Add(new City { CityName = "Hà Nội", CountryName = VN.CountryName, ImgSrc = "hn.jpg" });
            VN.Add(new City { CityName = "Đà Nẵng", CountryName = VN.CountryName, ImgSrc = "dn.jpg" });
            VN.Add(new City { CityName = "Đà Lạt", CountryName = VN.CountryName, ImgSrc = "dl.jpg" });

            nationList.Add(VN);

            Country USA = new Country("USA");
            USA.Description = "United State America";
            USA.Add(new City { CityName = "New York", CountryName = VN.CountryName, ImgSrc = "ny.jpg" });
            USA.Add(new City { CityName = "Chicago", CountryName = VN.CountryName, ImgSrc = "ccg.jpg" });
            USA.Add(new City { CityName = "Washington D.C", CountryName = VN.CountryName, ImgSrc = "wst.jpg" });
            USA.Add(new City { CityName = "Las Vegas", CountryName = VN.CountryName, ImgSrc = "lv.jpg" });

            nationList.Add(USA);

            NationPicker.ItemsSource = nationList;
        }
        public void CityListInit(string option)
        {
            List<City> selectedCity = new List<City>();
            if (option == "Việt Nam") foreach (City city in nationList[1])  selectedCity.Add(city); 
            if (option == "USA") foreach (City city in nationList[2]) selectedCity.Add(city);
            if (option == "All") foreach (Country nation in nationList) foreach (City city in nation) selectedCity.Add(city);

            City.ItemsSource = selectedCity;
        }
        public Bai3()
        {
            InitializeComponent();
            NationInit();
            CityListInit("All");
        }

        private void NationPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int index = picker.SelectedIndex;
            string nation = picker.Items[index].ToString();
            Console.WriteLine(nation);
            CityListInit(nation);
        }

        private void Book_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void City_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}