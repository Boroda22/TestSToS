using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    /// <summary>
    /// Книга
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Автор книги
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Название книги
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Год издания книги
        /// </summary>
        public string YearPublication { get; set; }
    }
}
