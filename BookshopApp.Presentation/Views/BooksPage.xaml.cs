using BookshopApp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshopApp.Presentation.Views
{
    public partial class BooksPage : ContentPage
    {
        private readonly BookService _bookService;

        public BooksPage(BookService bookService)
        {
            InitializeComponent();
            _bookService = bookService;
            LoadBooks();
        }

        private async void LoadBooks()
        {
            var books = await _bookService.GetAllBooksAsync();
            //BooksListView.ItemsSource = books;
        }

        private void InitializeComponent()
        {
            // Add your initialization logic here
        }
    }
}
