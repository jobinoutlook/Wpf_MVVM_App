using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_MVVM_App.Models
{
    public class BookManager
    {
        public static ObservableCollection<Book> _DatabaseBooks = new ObservableCollection<Book>() { new Book() { Title = "adkndv", Author = "kfgd" } };
        
        public static ObservableCollection<Book> GetBooks()
        {
            return _DatabaseBooks;

        }


        public static void AddBook(Book book)
        {
            _DatabaseBooks.Add(book);

        }
    }
}
