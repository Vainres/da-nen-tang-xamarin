using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;
using System.Data;//import this namespace


namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bai5 : ContentPage
    {
        public Bai5()
        {
            InitializeComponent();
            render();
        }
        void render()
        {
            for (int i = 0; i < 4; i++)
            {
                CalculatorButton.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 4; i++)
            {
                CalculatorButton.ColumnDefinitions.Add(new ColumnDefinition());
            }
            string[] listtxtbtn = new string[] { "C", "X", "%", "/", "7", "8", "9", "*", "4", "5", "6", "-", "1", "2", "3", "+", "0", ".", "=", "" };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 4 && j == 3) { break; }
                    if (i != 4 || j != 2)
                    {
                        int a = 4 * i + j;
                        Button n = new Button { Text = listtxtbtn[a], HeightRequest = 100, Margin = 0, BorderWidth = 0.1, CornerRadius = 0 };
                        n.BackgroundColor = Color.OrangeRed;
                        n.TextColor = Color.White;
                        CalculatorButton.Children.Add(n, j, i);
                        n.Clicked += N_Clicked; ;
                    }
                    else
                    {
                        Button n = new Button { Text = "=", HeightRequest = 100, Margin = 0, BorderWidth = 0.1, CornerRadius = 0 };
                        n.BackgroundColor = Color.White;
                        n.TextColor = Color.Black;
                        CalculatorButton.Children.Add(n, j, i);
                        Grid.SetColumnSpan(n, 2);
                        n.Clicked += N_Clicked;
                    }
                }


            }
        }

        private void N_Clicked(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            if (btn.Text != "=")
                SubLine.Text = "";
            if (btn.Text == "C")
            {
                MainLine.Text = "0";

            }
            else if (btn.Text == "X")
            {
                MainLine.Text = MainLine.Text.Remove(MainLine.Text.Length - 1);
                if (MainLine.Text.Length == 0)
                {
                    MainLine.Text = "0";

                }

            }
            else if (btn.Text != "=")
            {
                double y = 0;
                double.TryParse(btn.Text, out y);
                if (y != 0)
                {
                    MainLine.Text += btn.Text;
                }
                else if (btn.Text == "0")
                {
                    MainLine.Text += "0";
                }
                else
                {
                    MainLine.Text += btn.Text;
                    if (MainLine.Text[MainLine.Text.Length - 1] == MainLine.Text[MainLine.Text.Length - 2])
                    {
                        MainLine.Text = MainLine.Text.Remove(MainLine.Text.Length - 1);
                    }
                    if (btn.Text != "-" && btn.Text != "+")
                        if (MainLine.Text[MainLine.Text.Length - 2] == '%' || MainLine.Text[MainLine.Text.Length - 2] == '*' || MainLine.Text[MainLine.Text.Length - 2] == '/' || MainLine.Text[MainLine.Text.Length - 2] == '+' || MainLine.Text[MainLine.Text.Length - 2] == '-')
                        {
                            MainLine.Text = MainLine.Text.Remove(MainLine.Text.Length - 2, 1);
                        }
                }
            }
            if (MainLine.Text[0] == '0' && MainLine.Text.Length > 1 && MainLine.Text[1] != '.')
            {
                MainLine.Text = MainLine.Text.Remove(0, 1);
            }
            if (MainLine.Text[0] == '%' || MainLine.Text[0] == '*' || MainLine.Text[0] == '/')
            {
                MainLine.Text = "0";
            }
            if (btn.Text == "=")
            {
                if (MainLine.Text[MainLine.Text.Length - 1] == '%' || MainLine.Text[MainLine.Text.Length - 1] == '*' || MainLine.Text[MainLine.Text.Length - 1] == '/' || MainLine.Text[MainLine.Text.Length - 1] == '+' || MainLine.Text[MainLine.Text.Length - 1] == '-')
                {
                    MainLine.Text = MainLine.Text.Remove(MainLine.Text.Length - 1);
                }
                SubLine.Text = MainLine.Text + '=';
                string t = "0";
                try
                {
                    t = new DataTable().Compute(MainLine.Text, null).ToString();
                }
                catch
                {
                }
                MainLine.Text = t;


            }

        }
    }
}