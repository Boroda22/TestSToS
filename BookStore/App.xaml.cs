using BookStore.Model;
using BookStore.ViewModel;

using System.Windows;

namespace BookStore
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            MainModel model = new MainModel();
            MainWindowViewModel viewModel = new MainWindowViewModel(model);

            new MainWindow() { DataContext = viewModel }.Show();
        }
    }
}
