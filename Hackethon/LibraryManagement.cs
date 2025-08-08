using System;
using System.Collections.Generic;

namespace Hackathon
{
    internal class LibraryManagement
    {
        static List<string> SortTitles(List<string> bookList)
        {
            var extractedBooks = new List<(string author, string title)>();

            foreach (var book in bookList)
            {
                var splitParts = book.Split(" by ");
                var title = splitParts[0].Replace("\"", "");
                var author = splitParts[1].Split("and")[0].Trim();

                extractedBooks.Add((author, title));
            }

            return SortBooks(extractedBooks);
        }

        private static List<string> SortBooks(List<(string author, string title)> books)
        {
            int count = books.Count;
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    bool swap = false;

                    if (string.Compare(books[j].author, books[j + 1].author) > 0)
                    {
                        swap = true;
                    }
                    else if (books[j].author == books[j + 1].author &&
                             string.Compare(books[j].title, books[j + 1].title) > 0)
                    {
                        swap = true;
                    }

                    if (swap)
                    {
                        var temp = books[j];
                        books[j] = books[j + 1];
                        books[j + 1] = temp;
                    }
                }
            }

            var sortedTitles = new List<string>();
            foreach (var item in books)
            {
                sortedTitles.Add(item.title);
            }

            return sortedTitles;
        }

        static void Main()
        {
            Console.Write("Enter number of books: ");
            int totalBooks = Convert.ToInt32(Console.ReadLine());

            var inputBooks = new List<string>();
            Console.WriteLine("Please enter books in format: \"Title\" by Author");

            for (int i = 0; i < totalBooks; i++)
            {
                string bookEntry = Console.ReadLine();
                inputBooks.Add(bookEntry);
            }

            var result = SortTitles(inputBooks);

            Console.WriteLine("\nSorted Titles:");
            foreach (var title in result)
            {
                Console.WriteLine(title);
            }
        }
    }
}
