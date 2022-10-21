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
    public partial class HotelDetail : ContentPage
    {
        public HotelDetail(Hotel hotel)
        {
            Image img = new Image { Source = hotel.ImgSrc };
            Label Address = new Label { Padding = 5, Text = hotel.Address ,FontAttributes = FontAttributes.Bold,FontSize=20};
            Label Price = new Label { Padding = 5, Text = "Giá :"+hotel.Price, FontAttributes = FontAttributes.Bold, FontSize = 15 ,TextColor=Color.Red};

            Label tex = new Label { Text = hotel.Detail , Padding = 15 };
            InitializeComponent();
            detailH.Children.Add(img);
            detailH.Children.Add(Address);
            detailH.Children.Add(Price);
            detailH.Children.Add(tex);
            contP.Title = hotel.Name;

        }
    }
}