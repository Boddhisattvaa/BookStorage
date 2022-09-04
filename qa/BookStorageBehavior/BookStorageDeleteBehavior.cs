using System;
using qa.Entities;
namespace qa.BookStorageBehavior
{
    public class BookStorageDeleteBehavior
    {
        public void DeleteBook()
        {
            Console.Clear();
            using (var context = new BookStorageDbContext())
            {
                Console.WriteLine("Find these books : ");
                var books = context.Books.ToList();
                foreach (Book b in books)
                {
                    Console.WriteLine(b.Id + " - " + b.Title);
                }
                Console.WriteLine("Введите id книги : ");
                int deleteInput = int.Parse(Console.ReadLine());
                var book = context.Books.Where(b => b.Id == deleteInput).FirstOrDefault();
                context.Books.Remove(book);
                context.SaveChanges();
                Console.WriteLine("Книга удалена");
                Console.Clear();
                Menu.PrintMenu();
            }
        }
        public void DeleteAuthor()
        {
            Console.Clear();
            using (var context = new BookStorageDbContext())
            {
                Console.WriteLine("Find these authors : ");
                var authors = context.Authors.ToList();
                foreach (Author a in authors)
                {
                    Console.WriteLine(a.Id + " - " + a.FirstName + " " + a.SurName);
                }
                Console.WriteLine("Введите id автора : ");
                int deleteInput = int.Parse(Console.ReadLine());
                var author = context.Authors.Where(a => a.Id == deleteInput).FirstOrDefault();
                context.Authors.Remove(author);
                context.SaveChanges();
                Console.WriteLine("Автор удален");
                Console.Clear();
                Menu.PrintMenu();
            }
        }
    }
}