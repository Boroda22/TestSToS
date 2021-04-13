using BookStore.Model;
using BookStore.Service;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookStore.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        /// <summary>
		/// Основная модель
		/// </summary>
		private MainModel mainModel;

        /// <summary>
        /// Обновление представления списка книг
        /// </summary>
        private void updateBooksView()
        {
            Books = mainModel.GetBooks();
            OnPropertyChanged("Books");
        }



        #region ОБРАБОТЧИКИ КОМАНД
        /// <summary>
        /// Тестовая команда
        /// </summary>
        private void BuyBook()
        {
            if(SelectedBook != null)
            {
                mainModel.BuyBook(SelectedBook.Id);
                updateBooksView();
            }
        }


        #endregion


        #region КОМАНДЫ
        public ICommand BuyBookCommand
        {
            get { return new DelegateCommand(BuyBook); }
        }
        
        #endregion



        /// <summary>
        /// Коллекция книг
        /// </summary>
        public ObservableCollection<Book> Books { get; set; }
        /// <summary>
        /// Выбранная книга
        /// </summary>
        public Book SelectedBook { get; set; }



        public MainWindowViewModel(MainModel model)
        {
            mainModel = model;
            updateBooksView();
        }

        // реализация обработчиков INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
