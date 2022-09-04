using System;

namespace qa.BookStorageBehavior
{
    public class BookStorageSearchBehavior
    {
        public void SearchBook()
        {
            using (var context = new BookStorageDbContext())
            {
                try
                {
                    Console.WriteLine("Введите название книги");
                    string titleInput = Console.ReadLine();
                    var book = context.Books.Where(b => b.Title == titleInput).FirstOrDefault();
                    if (book.Title != null)
                    {
                        Console.WriteLine($"Найдено : {book.Title}, аннотация - {book.Annotation}, количество страниц - {book.PageCount}, цена - {book.Price}");
                        Console.WriteLine("Нажмите на любую клавишу, чтобы вернуться в главное меню");
                        Console.ReadKey();
                        Console.Clear();
                        Menu.PrintMenu();
                    }
                }
                catch (NullReferenceException exception)
                {
                    Console.WriteLine("Книга не найдена");
                    Console.WriteLine("Нажмите на любую клавишу, чтобы вернуться в главное меню");
                    Console.ReadKey();
                    Console.Clear();
                    Menu.PrintMenu();
                }
            }
        }
        public void SearchAuthor()
        {
            using (var context = new BookStorageDbContext())
            {
                try
                {
                    Console.WriteLine("Введите имя автора");
                    string nameInput = Console.ReadLine();
                    var author = context.Authors.Where(a => a.FirstName == nameInput).FirstOrDefault();
                    if (author.FirstName != null)
                    {
                        Console.WriteLine("Найдено : " + author.FirstName + " " + author.SurName + "; пол - " + author.Sex);
                        Console.WriteLine("Нажмите на любую клавишу, чтобы вернуться в главное меню");
                        Console.ReadKey();
                        Console.Clear();
                        Menu.PrintMenu();
                    }
                }
                catch (NullReferenceException exception)
                {
                    Console.WriteLine("Автор не найден");
                    Console.WriteLine("Нажмите на любую клавишу, чтобы вернуться в главное меню");
                    Console.ReadKey();
                    Console.Clear();
                    Menu.PrintMenu();
                }
            }
        }
    }
}
