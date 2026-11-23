namespace Tyuiu.KravchenkoDS.Sprint7.Project.V4.Lib
{
    public class DataService
    {
        public List<Book> LoadFromFile(string path)
        {
            List<Book> books = new List<Book>();
            foreach (string line in File.ReadAllLines(path))
            {
                string[] parts = line.Split(';');
                books.Add(new Book
                {
                    Author = parts[0],
                    Title = parts[1],
                    Year = int.Parse(parts[2]),
                    Price = int.Parse(parts[3]),
                    IsNew = parts[4] == "да",
                    Copies = int.Parse(parts[5])
                });
            }
            return books;
        }

        public void SaveToFile(string path, List<Book> books)
        {
            List<string> lines = new List<string>();
            foreach (Book b in books)
            {
                string isNewText = b.IsNew ? "да" : "нет";
                lines.Add($"{b.Author};{b.Title};{b.Year};{b.Price};{isNewText};{b.Copies}");
            }
            File.WriteAllLines(path, lines);
        }
        public List<Book> Search(List<Book> books, string text)
        {
            List<Book> result = new List<Book>();

            foreach (Book b in books)
            {
                if (b.Author.Contains(text, StringComparison.OrdinalIgnoreCase) ||
                    b.Title.Contains(text, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(b);
                }
            }
            return result;
        }
        public List<Book> SortByPrice(List<Book> books)
        {
            return books.OrderBy(b => b.Price).ToList();
        }

        public List<Book> SortByYear(List<Book> books)
        {
            return books.OrderBy(b => b.Year).ToList();
        }

        public List<Book> SortByAuthor(List<Book> books)
        {
            return books.OrderBy(b => b.Author).ToList();
        }
        public int GetCount(List<Book> books)
        {
            return books.Count;
        }

        public int GetTotalCopies(List<Book> books)
        {
            return books.Sum(b => b.Copies);
        }

        public int GetSumPrice(List<Book> books)
        {
            return books.Sum(b => b.Price);
        }

        public double GetAveragePrice(List<Book> books)
        {
            if (books.Count == 0) return 0;
            return books.Average(b => b.Price);
        }

        public int GetMaxPrice(List<Book> books)
        {
            if (books.Count == 0) return 0;
            return books.Max(b => b.Price);
        }

        public int GetMinPrice(List<Book> books)
        {
            if (books.Count == 0) return 0;
            return books.Min(b => b.Price);
        }

        public List<Book> FilterNew(List<Book> books)
        {
            return books.Where(b => b.IsNew).ToList();
        }

        public List<Book> FilterByYear(List<Book> books, int fromYear, int toYear)
        {
            return books.Where(b => b.Year >= fromYear && b.Year <= toYear).ToList();
        }
    }
}

    




