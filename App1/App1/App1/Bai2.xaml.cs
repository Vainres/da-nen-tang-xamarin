using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bai2 : ContentPage
    {

        void Table()
        {
            for(int i=0;i<4;i++) table.ColumnDefinitions.Add(new ColumnDefinition());
            for (int i = 0; i < 4; i++) table.RowDefinitions.Add(new RowDefinition());
            for (int i = 0; i < 4; i++)
            {
                BoxView b1 = new BoxView();
                BoxView b2 = new BoxView();
                BoxView b3 = new BoxView();
                BoxView b4 = new BoxView();
                b1.Color = Color.Aqua;
                b2.Color = Color.Lavender;
                b3.Color = Color.Aqua;
                b4.Color = Color.Lavender;
                if (i%2 == 0)
                {
                    b2.Color = Color.Aqua;
                    b1.Color = Color.Lavender;
                    b4.Color = Color.Aqua;
                    b3.Color = Color.Lavender;
                }
                table.Children.Add(b1, 0, i);
                table.Children.Add(b2, 1, i);
                table.Children.Add(b3, 2, i);
                table.Children.Add(b4, 3, i);

            }
        }
        public Bai2()
        {
            InitializeComponent();
            Table();
        }
    }
}