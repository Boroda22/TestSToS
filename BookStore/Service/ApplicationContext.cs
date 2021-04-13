using BookStore.Model;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service
{
    /// <summary>
    /// Контекст базы данных
    /// </summary>
    class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {
        }

        /// <summary>
        /// Книги
        /// </summary>
        public IDbSet<Book> Books { get; set; }
    }
}
