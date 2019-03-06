using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MyReadBooks.Models;
using Prism.AppModel;
using Prism.Commands;
using Prism.Navigation;
using SQLite;

namespace MyReadBooks.ViewModels
{
    public class BooksVM : IPageLifecycleAware
    {
        public ObservableCollection<Best_book> Books { get; set; }
        public ICommand NewBookCommand { get; set; }
        INavigationService _navigationService;
        public BooksVM(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NewBookCommand = new DelegateCommand(NewBookAction);
            Books = new ObservableCollection<Best_book>();
            ReadSavedBooks();
        }

        private void ReadSavedBooks()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabasePath))
            {
                conn.CreateTable<Best_book>();
                var books = conn.Table<Best_book>().ToList();
                Books.Clear();
                foreach (var book in books)
                {
                    Books.Add(book);
                }
            }
        }

        private async void NewBookAction()
        {
            await _navigationService.NavigateAsync("NewBookPage");
        }

        public void OnAppearing()
        {
            ReadSavedBooks();
        }

        public void OnDisappearing()
        {

        }
    }
}
