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
    public class City 
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string ImgSrc { get; set; }

    }
    public partial class Bai2 : ContentPage
    {
        List<City> dsTP;
        public Bai2()
        {
            dsTP = new List<City>();
            dsTP.Add(new City { Name = "Hồ Chí Minh" ,ID=1,ImgSrc="hcm.jpg"});
            dsTP.Add(new City { Name = "Hà Nội", ID = 2, ImgSrc = "hn.jpg" });
            dsTP.Add(new City { Name = "Đà Nẵng", ID = 3, ImgSrc = "dn.jpg" });
            dsTP.Add(new City { Name = "Đà Lạt", ID = 4, ImgSrc = "dl.jpg" });
            InitializeComponent();
            dsThanhPho.ItemsSource = dsTP;
        }

        public void CitySelected(object sender,SelectedItemChangedEventArgs e)
        {
            City forwa = (City)e.SelectedItem;
            Console.WriteLine(forwa.Name,forwa.ID);

            Navigation.PushAsync(new HotelList(forwa));
        }
    }
}