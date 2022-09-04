using qa.BookStorageBehavior;
using qa.Entities;
namespace qa
{
    public class Menu
    {
        public static void PrintMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Добро пожаловать в консольное хранилище книг: ");
            Console.WriteLine("Add book - Добавить книгу в существующее хранилище c автором/без автора");
            Console.WriteLine("Delete book - Удалить книгу с существующего хранилища");
            Console.WriteLine("Add author -  Добавить автора в существующее хранилище");
            Console.WriteLine("Delete author - Удалить автора с существующего хранилища");
            Console.WriteLine("Show books - посмотреть все книги в хранилище");
            Console.WriteLine("Search book - Поиск книги по названию");
            Console.WriteLine("Show authors - посмотреть всех авторов в хранилище");
            Console.WriteLine("Search author - Поиск автора по названию");
            Console.WriteLine("Change - Поменять какие-то значения у сущности автора/книги");
            Console.WriteLine("Quit - Завершение программы");
            var addBehavior = new BookStorageAddBehavior();
            var deleteBehavior = new BookStorageDeleteBehavior();   
            var showBehavior = new BookStorageShowBehavior();
            var searchBehavior = new BookStorageSearchBehavior();
            var changeBehavior = new BookStorageChangeBehavior();

            while (true)
            {
                Console.Write(">");
                Console.CursorVisible = false;
                string menuInput = Console.ReadLine();
                menuInput = menuInput.ToLower();
                if (menuInput == "add book")
                {
                    addBehavior.AddBook();
                }
                else if (menuInput == "delete book")
                {
                    deleteBehavior.DeleteBook();
                }
                else if (menuInput == "add author")
                {
                    addBehavior.AddAuthor();
                }
                else if (menuInput == "delete author")
                {
                    deleteBehavior.DeleteAuthor();
                }
                else if (menuInput == "show books")
                {
                    showBehavior.ShowBooks();
                }
                else if (menuInput == "search book")
                {
                    searchBehavior.SearchBook();
                }
                else if (menuInput == "show authors")
                {
                    showBehavior.ShowAuthors();
                }
                else if (menuInput == "search author")
                {
                    searchBehavior.SearchAuthor();
                }
                else if (menuInput == "change")
                {
                    changeBehavior.ChangeEntity();
                }
                else if (menuInput == "quit")
                {
                    Console.Clear();
                    Console.WriteLine("Bye!!!");
                    Environment.Exit(0);
                }
            }
        }
    }
}
