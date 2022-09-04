using qa.Entities;
namespace qa.BookStorageBehavior
{
    public class BookStorageShowBehavior
    {
        public void ShowBooks()
        {
            Console.Clear();
            using (var context = new BookStorageDbContext())
            {
                Console.WriteLine("Find these books : ");
                var books = context.Books.ToList();
                foreach (Book book in books)
                {
                    Console.WriteLine(book.Title);
                }
            }
            Console.WriteLine("Нажмите на любую клавишу, чтобы вернуться в главное меню");
            Console.ReadKey();
            Console.Clear();
            Menu.PrintMenu();
        }
        public void ShowAuthors()
        {
            Console.Clear();
            using (var context = new BookStorageDbContext())
            {
                Console.WriteLine("Find these authors : ");
                var authors = context.Authors.ToList();
                foreach (Author author in authors)
                {
                    Console.WriteLine(author.FirstName + " " + author.SurName);
                }
            }
            Console.WriteLine("Нажмите на любую клавишу, чтобы вернуться в главное меню");
            Console.ReadKey();
            Console.Clear();
            Menu.PrintMenu();
        }
    }
}
