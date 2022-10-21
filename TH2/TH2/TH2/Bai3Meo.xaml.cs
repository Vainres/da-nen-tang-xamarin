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

    public class Race
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string ImgSrc { get; set; }

    }

    public partial class Bai3Meo : ContentPage
    {
        public List<Race> dsLoaiVat;

        public Bai3Meo()
        {
            dsLoaiVat = new List<Race>();
            dsLoaiVat.Add(new Race { Name = "Chó", ID = 1, ImgSrc = "cho.jpg" });
            dsLoaiVat.Add(new Race { Name = "Mèo", ID = 2, ImgSrc = "meo.jpg" });
            dsLoaiVat.Add(new Race { Name = "Cáo", ID = 3, ImgSrc = "cao.jpg" });
            dsLoaiVat.Add(new Race { Name = "Chim", ID = 4, ImgSrc = "chim.webp" });
            InitializeComponent();
            dsLoai.ItemsSource = dsLoaiVat;
        }
        public void RaceSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Race forwa = (Race)e.SelectedItem;
            Console.WriteLine(forwa.Name, forwa.ID);

            Navigation.PushAsync(new RaceListB3(forwa));
        }
    }
}