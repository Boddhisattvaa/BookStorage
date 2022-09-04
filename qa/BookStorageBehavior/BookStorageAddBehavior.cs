using qa.Entities;
namespace qa.BookStorageBehavior
{
    public class BookStorageAddBehavior
    {
        public void AddBook()
        {
            Console.Clear();
            Console.WriteLine("1 - Добавить книгу с автором ");
            Console.WriteLine("2 - Добавить книгу без автора ");
            Console.Write(">");
            Console.CursorVisible = false;
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.Clear();
                Console.Write(">");
                Console.CursorVisible = false;
                while (true)
                {
                    try
                    {
                        Console.Write("Введите название книги : ");
                        string titleInput = Console.ReadLine();
                        Console.Write("Введите дату создания книги(yyyy/mm/dd) : ");
                        DateTime creationDateInput = DateTime.Parse(Console.ReadLine());
                        Console.Write("Введите аннотацию для книги : ");
                        string annotationInput = Console.ReadLine();
                        Console.Write("Введите количество страниц книги : ");
                        int pageCountInput = int.Parse(Console.ReadLine());
                        Console.Write("Введите цену книги : ");
                        int priceInput = int.Parse(Console.ReadLine());

                        Console.Write("Введите имя автора : ");
                        string nameInput = Console.ReadLine();
                        Console.Write("Введите фамилию автора : ");
                        string surnameInput = Console.ReadLine();
                        Console.Write("Введите пол автора(m/f) : ");
                        char sexInput = char.Parse(Console.ReadLine());
                        Console.Write("Введите дату рождения автора(yyyy/mm/dd) : ");
                        DateTime birthDateInput = DateTime.Parse(Console.ReadLine());

                        using (var context = new BookStorageDbContext())
                        {
                            Book book = new Book
                            {
                                Title = titleInput,
                                CreationDate = creationDateInput,
                                Annotation = annotationInput,
                                PageCount = pageCountInput,
                                Price = priceInput,
                            };
                            context.Books.Add(book);
                            Author author = new Author
                            {
                                FirstName = nameInput,
                                SurName = surnameInput,
                                Sex = sexInput,
                                BirthDate = birthDateInput
                            };
                            context.Authors.Add(author);
                            book.Authors.Add(author);
                            context.SaveChanges();
                        }
                        Console.WriteLine("Книга и автор добавлены");
                        Console.Clear();
                        Menu.PrintMenu();
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine("Неправильный ввод");
                    }
                }
            }
            else if (input == "2")
            {
                Console.Clear();
                Console.Write(">");
                Console.CursorVisible = false;
                while (true)
                {
                    try
                    {
                        Console.Write("Введите название книги : ");
                        string titleInput = Console.ReadLine();
                        Console.Write("Введите дату создания книги(yyyy/mm/dd) : ");
                        DateTime creationDateInput = DateTime.Parse(Console.ReadLine());
                        Console.Write("Введите аннотацию для книги : ");
                        string annotationInput = Console.ReadLine();
                        Console.Write("Введите количество страниц книги : ");
                        int pageCountInput = int.Parse(Console.ReadLine());
                        Console.Write("Введите цену книги : ");
                        int priceInput = int.Parse(Console.ReadLine());

                        using (var context = new BookStorageDbContext())
                        {
                            Book book = new Book
                            {
                                Title = titleInput,
                                CreationDate = creationDateInput,
                                Annotation = annotationInput,
                                PageCount = pageCountInput,
                                Price = priceInput,
                            };
                            context.Books.Add(book);
                            context.SaveChanges();
                        }
                        Console.WriteLine("Книга добавлена");
                        Console.Clear();
                        Menu.PrintMenu();
                    }
                    catch (Exception exception)
                    { Console.WriteLine("Неправильный ввод"); }
                }
            }
        }
        public void AddAuthor()
        {
            Console.Clear();
            Console.Write(">");
            Console.CursorVisible = false;
            while (true)
            {
                try
                {
                    Console.Write("Введите имя автора : ");
                    string nameInput = Console.ReadLine();
                    Console.Write("Введите фамилию автора : ");
                    string surnameInput = Console.ReadLine();
                    Console.Write("Введите пол автора(m/f) : ");
                    char sexInput = char.Parse(Console.ReadLine());
                    Console.Write("Введите дату рождения автора(yyyy/mm/dd) : ");
                    DateTime birthDateInput = DateTime.Parse(Console.ReadLine());

                    using (var context = new BookStorageDbContext())
                    {
                        Author author = new Author
                        {
                            FirstName = nameInput,
                            SurName = surnameInput,
                            Sex = sexInput,
                            BirthDate = birthDateInput
                        };
                        context.Authors.Add(author);
                        context.SaveChanges();
                    }
                    Console.WriteLine("Автор добавлен");
                    Console.Clear();
                    Menu.PrintMenu();
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Неправильный ввод");
                }
            }
        }
    }
}
