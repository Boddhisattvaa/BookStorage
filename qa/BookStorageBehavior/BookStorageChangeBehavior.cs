using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Diagnostics;
using qa.Entities;

namespace qa.BookStorageBehavior
{
    public class BookStorageChangeBehavior
    {
        public void ChangeEntity()
        {
            Console.Clear();
            Console.WriteLine("1 - Изменить значения у автора");
            Console.WriteLine("2 - Изменить значения у книги ");
            Console.Write(">");
            Console.CursorVisible = false;
            string input = Console.ReadLine();
            if (input == "1")
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
                    int changeInput = int.Parse(Console.ReadLine());
                    var author = context.Authors.Where(a => a.Id == changeInput).FirstOrDefault();
                    Console.Clear();
                    Console.Write("Введите новое имя автора : ");
                    string nameInput = Console.ReadLine();
                    Console.Write("Введите новую фамилию автора : ");
                    string surnameInput = Console.ReadLine();
                    Console.Write("Введите пол автора(m/f) : ");
                    char sexInput = char.Parse(Console.ReadLine());
                    Console.Write("Введите дату рождения автора(yyyy/mm/dd) : ");
                    DateTime birthDateInput = DateTime.Parse(Console.ReadLine());

                    if (author != null)
                    {
                        author.FirstName = nameInput;
                        author.SurName = surnameInput;
                        author.Sex = sexInput;
                        author.BirthDate = birthDateInput;
                        context.SaveChanges();
                    }
                    Console.WriteLine("Автор изменен");
                    Console.Clear();
                    Menu.PrintMenu();
                }
            }
            else if (input == "2")
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
                    Console.Clear();
                    Console.Write("Введите новое название книги : ");
                    string titleInput = Console.ReadLine();
                    Console.Write("Введите дату создания книги(yyyy/mm/dd) : ");
                    DateTime creationDateInput = DateTime.Parse(Console.ReadLine());
                    Console.Write("Введите аннотацию для книги : ");
                    string annotationInput = Console.ReadLine();
                    Console.Write("Введите количество страниц книги : ");
                    int pageCountInput = int.Parse(Console.ReadLine());
                    Console.Write("Введите цену книги : ");
                    int priceInput = int.Parse(Console.ReadLine());
                    if (book != null)
                    {
                        book.Title = titleInput;
                        book.CreationDate = creationDateInput;
                        book.Annotation = annotationInput;
                        book.PageCount = pageCountInput;
                        book.Price = priceInput;
                        context.SaveChanges();
                    }
                    Console.WriteLine("Книга изменена");
                    Console.Clear();
                    Menu.PrintMenu();
                }
            }
        }
    }
}
