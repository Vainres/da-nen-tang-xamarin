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
    public partial class AnimalDetail : ContentPage
    {
        public AnimalDetail(Animal animal)
        {
            Image img = new Image { Source = animal.ImgSrc };

            Label tex = new Label { Text = animal.Detail, Padding = 15 };
            InitializeComponent();
            detailH.Children.Add(img);
            detailH.Children.Add(tex);
            contP.Title = animal.Name;
        }
    }
}