using PortableLibrary.Models;
using PortableLibrary.Services;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace PortableLibrary.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly IMessageService _messageService;
        private readonly IBooksService _booksService;

        public MainViewModel(IMessageService messageService, IBooksService booksService)
        {
            if (messageService == null) throw new ArgumentNullException(nameof(messageService));
            if (booksService == null) throw new ArgumentNullException(nameof(booksService));
            _messageService = messageService;
            _booksService = booksService;

            Task t1 = RefreshBooksAsync();
            ActionCommand = new DelegateCommand(Action);
        }

        private async Task RefreshBooksAsync()
        {
            Books.Clear();
            var books = await _booksService.GetBooksAsync();
            foreach (var book in books)
            {
                Books.Add(book);
            }
            SelectedBook = Books?.First();
        }

        public ObservableCollection<Book> Books { get; } = new ObservableCollection<Book>();

        public string Title => "Sample - DI Container";

        private Book _selectedBook;

        public Book SelectedBook
        {
            get { return _selectedBook; }
            set { SetProperty(ref _selectedBook, value); }
        }



        public DelegateCommand ActionCommand { get; private set; }

        public async void Action()
        {
            await _messageService.MessageAsync("Hello from the view-model");
        }
    }
}
