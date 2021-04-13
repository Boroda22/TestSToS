using BookStore.Service;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    class MainModel
    {
        /// <summary>
        /// Получить список книг
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<Book> GetBooks()
        {
            ObservableCollection<Book> result = new ObservableCollection<Book>();

            var dbContext = new ApplicationContext();

            var books = dbContext.Books.ToList();
            foreach (var item in books)
            {
                result.Add(item);
            }

            return result;
        }
        /// <summary>
        /// Покупка книги
        /// </summary>
        /// <param name="bookId"> идентификатор книги</param>
        public void BuyBook(int bookId)
        {
            var dbContext = new ApplicationContext();

            var tmpBook = dbContext.Books.Where(x => x.Id == bookId).FirstOrDefault();
            if(tmpBook != null)
            {
                dbContext.Books.Remove(tmpBook);
                dbContext.SaveChanges();
            }
            
        }
    }
}
