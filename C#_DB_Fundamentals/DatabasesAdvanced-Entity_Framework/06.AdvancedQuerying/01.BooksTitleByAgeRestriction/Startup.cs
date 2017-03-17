using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01.BooksTitleByAgeRestriction
{
    class Startup
    {
        static void Main(string[] args)
        {
            var context = new BookShopContext();

            // UNCOMMENT ONE BY ONE FOR CHECKING!

            //01.Books Title by Age Restriction
            //BooksTitleByAgeRestriction(context);

            //02.Golden Books
            //GoldenBooks(context);

            //03.Books by Price
            //BooksByPrice(context);

            //04.Not Released Books
            //NotReleasedBooks(context);

            //05.Book Titles by Category
            //BooksByCategory(context);

            //06.Books released before date
            //BooksReleasedBeforeDate(context);

            //07.Authors search
            //AuthorSearch(context);

            //08.Books Search
            //BooksSearch(context);

            //09.Book title search
            //BookTitleSearch(context);

            //10.CountBooks
            //CountBooks(context);

            //11.Total Book Copies
            //TotalBookCopies(context);

            //12.Find Profit
            //FindProfit(context);

            //13.MostRecentBooks
            //MostRecentBooks(context);

            //14.Increase Book Copies
            //IncreaseBookCopies(context);

            //15.Remove Books
            // RemoveBooks(context);

            //16.Stored Procedure
            //StoedProcedure(context);


        }

        private static void StoedProcedure(BookShopContext context)
        {
//CREATE PROCEDURE GetAuthorBooksCount @firstName NVARCHAR(MAX), 
//@lastName NVARCHAR(MAX),
// @result INT OUT
// AS
//SET @result = (
//SELECT COUNT(*) AS COUNT FROM Authors AS a
//inner join Books AS b
//ON b.AuthorId = a.Id
//WHERE a.FirstName = @firstName and a.LastName = @lastName)

            Console.Write("Enter First Name and Second Name: ");
            string[] names = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();

            SqlParameter firstName = new SqlParameter("@firstName", names[0]);
            SqlParameter lastName = new SqlParameter("@lastName", names[1]);
            SqlParameter result = new SqlParameter();
            result.ParameterName = "@result";
            result.Direction = System.Data.ParameterDirection.Output;
            result.SqlDbType = SqlDbType.Int;

            context.Database.ExecuteSqlCommand($"execute GetAuthorBooksCount  @firstName, @lastName, @result output", result, firstName, lastName);
            Console.WriteLine($"{firstName.Value} {lastName.Value} has written {result.Value} books");

        }

        private static void RemoveBooks(BookShopContext context)
        {
            int deletedCount = 0;
            var books = context.Books.Where(b => b.Copies < 4200);
            foreach (var b in books)
            {
                try
                {
                    context.Books.Remove(b);
                    deletedCount++;
                }
                catch (Exception)
                {

                    Console.WriteLine($"Can not delete book: {b.Title}");
                }

            }
            try
            {
                context.SaveChanges();
                Console.WriteLine($"{deletedCount} books were deleted");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        private static void IncreaseBookCopies(BookShopContext context)
        {
            int count = 44;
            var books = context.Books.Where(b => b.ReleaseDate > new DateTime(2013, 06, 06));

            foreach (var book in books)
            {
                book.Copies += count;
            }
            Console.WriteLine($"{books.Count() * count}");

        }

        private static void MostRecentBooks(BookShopContext context)
        {
            var categories = context.Categories
                .Where(c => c.Books.Count > 35)
                .OrderByDescending(c => c.Books.Count);
            var books = context.Books
                .OrderByDescending(b => b.ReleaseDate)
                .ThenBy(b => b.Title).Take(3);

            foreach (var cat in categories)
            {
                Console.WriteLine($"--{cat.Name}: {cat.Books.Count} books");
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title} ({book.ReleaseDate.Value.Year})");
                }
            }
        }

        private static void FindProfit(BookShopContext context)
        {
            Dictionary<string, decimal> result = new Dictionary<string, decimal>();
            foreach (var category in context.Categories)
            {
                result[category.Name] = 0;
                foreach (var book in context.Books)
                {
                    if (book.Categories.Contains(category))
                    {
                        result[category.Name] += book.Copies * book.Price;
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result
                                                                .OrderByDescending(x => x.Value)
                                                                .ThenBy(x => x.Key)
                                                                .Select(kv => $"{kv.Key} - ${kv.Value}")));
        }

        private static void TotalBookCopies(BookShopContext context)
        {
            var books = context.Books.GroupBy(b => b.Author)
                                     .Select(b => new
                                     {
                                         Author = b.Key,
                                         Copies = b.Sum(c => c.Copies)
                                     })
                                     .OrderByDescending(c => c.Copies)
                                     .ToList();

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Author.FirstName} {book.Author.LastName} - {book.Copies}");
            }
        }

        private static void CountBooks(BookShopContext context)
        {
            int n = int.Parse(Console.ReadLine());
            var booksCount = context.Books
                .Where(b => b.Title.Length > n)
                .Count();
            Console.WriteLine(booksCount);

        }

        private static void BookTitleSearch(BookShopContext context)
        {
            string input = Console.ReadLine().ToLower();

            var books = context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(input))
                .ToList();
            foreach (var book in books.OrderBy(b => b.Id))
            {
                Console.WriteLine($"{book.Title} ({book.Author.FirstName} {book.Author.LastName})");
            }

        }

        private static void BooksSearch(BookShopContext context)
        {
            string input = Console.ReadLine();
            var books = context.Books.Where(b => b.Title.Contains(input)).ToList();

            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }

        }

        private static void AuthorSearch(BookShopContext context)
        {
            string input = Console.ReadLine();

            var authors = context.Authors
                .Where(a => a.FirstName.EndsWith(input)).ToList();
            foreach (var a in authors)
            {
                Console.WriteLine(a.FirstName + " " + a.LastName);
            }
        }

        private static void BooksReleasedBeforeDate(BookShopContext context)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            Console.Write("Enter date in format(dd-MM-yyyy): ");
            string input = Console.ReadLine();
            var date = DateTime.ParseExact(input, "dd-MM-yyyy", null);

            var books = context.Books.Where(b => b.ReleaseDate < date).ToList();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} - {book.Edition} - {book.Price}");
            }
        }

        private static void BooksByCategory(BookShopContext context)
        {
            Console.Write("Enter categories separated by space: ");
            string[] categories = Console.ReadLine()
                .Split(' ')
                .Select(c => c.ToLower())
                .ToArray();

            foreach (var book in context.Books)
            {
                if (book.Categories.Any(c => categories.Contains(c.Name.ToLower())))
                {
                    Console.WriteLine(book.Title);
                }
            }
        }

        private static void NotReleasedBooks(BookShopContext context)
        {
            Console.Write("Enter year:");
            int year = int.Parse(Console.ReadLine().Trim());

            context.Books.Where(
                b => b.ReleaseDate < new DateTime(year, 01, 01) ||
                b.ReleaseDate > new DateTime(year, 12, 31))
                .OrderBy(b => b.Id)
                .ToList()
                .ForEach(b => Console.WriteLine(b.Title));
        }


        private static void BooksByPrice(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Price < 5 || b.Price > 40);


            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} - ${book.Price}");
            }
        }

        private static void GoldenBooks(BookShopContext context)
        {
            var books = context.Books.Where(
                b => b.Edition
                .ToString()
                .Equals("Gold") && b.Copies < 5000)
                .Select(b => b.Title);


            Console.WriteLine(string.Join("\n", books));
        }

        private static void BooksTitleByAgeRestriction(BookShopContext context)
        {
            Console.Write("Enter age restriction: ");
            string input = Console.ReadLine().ToLower();

            var titles = context.Books
                .Where(b => b.AgeRestriction.ToString().ToLower().Equals(input))
                .Select(t => t.Title);

            Console.WriteLine(String.Join("\n", titles));

        }
    }
}
