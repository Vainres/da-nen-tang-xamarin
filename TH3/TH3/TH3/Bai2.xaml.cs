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
    public class Book
    {
        public string TitleBook { get; set; }
        public string ImgSrc { get; set; }
    }
    public partial class Bai2 : ContentPage
    {
        public List<Book> books;
        public void BookInit()
        {
            books = new List<Book>();
            books.Add(new Book { TitleBook = "Doremon", ImgSrc = "drm.jpg" });
            books.Add(new Book { TitleBook = "Naruto", ImgSrc = "nrt.jpg" });
            books.Add(new Book { TitleBook = "One Piece", ImgSrc = "op.jpg" });
            books.Add(new Book { TitleBook = "50 sắc thái", ImgSrc = "st50.jpg" });

            BookPicker.ItemsSource = books;

        }

        public void Cart(string title)
        {
            List<Book> selectedBook = new List<Book>();
            if(title!="")
            {
                foreach (Book book in books)
                {
                    if(book.TitleBook==title)
                    {
                        selectedBook.Add(book);
                    }
                }
                Book.ItemsSource = selectedBook;
            }
        }
        public Bai2()
        {
            InitializeComponent();
            BookInit();
            Cart("");
        }

        private void Book_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void BookPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            string title = picker.Items[selectedIndex].ToString();
            Cart(title);
        }
    }
}