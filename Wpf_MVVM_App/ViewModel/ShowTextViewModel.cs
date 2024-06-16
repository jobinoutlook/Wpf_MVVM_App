using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_MVVM_App.Commands;
using Wpf_MVVM_App.Models;

namespace Wpf_MVVM_App.ViewModel
{
    public class ShowTextViewModel
    {
        public ObservableCollection<Book> Books { get; set; }

        public ICommand AddBookCommand { get; set; }
        public string? Author { get; set; }

        public string? Title { get; set; }

        public ShowTextViewModel()
        {
            Books = BookManager.GetBooks();

            AddBookCommand = new RelayCommand(AddBook, CanAddBook);
        }

        private bool CanAddBook(object obj)
        {
            return true;
        }

        private void AddBook(object obj)
        {
            BookManager.AddBook(new Book { Title = Title, Author = Author });
        }
    }
}
