using Tyuiu.KravchenkoDS.Sprint7.Project.V4.Lib;


namespace Tyuiu.KravchenkoDS.Sprint7.Project.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "Books.csv");

            string[] lines = new string[]
            {
                "Толстой Л.Н.;Война и мир;2015;1200;нет;3",
                "Пушкин А.С.;Евгений Онегин;2017;400;нет;4",
                "Булгаков М.А.;Мастер и Маргарита;2022;750;да;5"
            };

            File.WriteAllLines(path, lines);

            DataService ds = new DataService();
            List<Book> books = ds.LoadFromFile(path);

            Assert.AreEqual(3, books.Count);
            Assert.AreEqual("Война и мир", books[0].Title);
            Assert.AreEqual(2017, books[1].Year);
            Assert.AreEqual(750, books[2].Price);
            Assert.IsFalse(books[0].IsNew);
            Assert.IsTrue(books[2].IsNew);
            Assert.AreEqual(3, books[0].Copies);
            Assert.AreEqual(5, books[2].Copies);
        }
    
    [TestMethod]
        public void ValidSearch()
        {
            DataService ds = new DataService();

            List<Book> books = new List<Book>
            {
                new Book { Author = "Толстой Л.Н.", Title = "Война и мир", Year = 2015, Price = 1200 },
                new Book { Author = "Толстой Л.Н.", Title = "Анна Каренина", Year = 2019, Price = 850 },
                new Book { Author = "Пушкин А.С.", Title = "Евгений Онегин", Year = 2017, Price = 400 }
            };

            List<Book> byAuthor = ds.Search(books, "толстой");
            List<Book> byTitle = ds.Search(books, "онегин");

            Assert.AreEqual(2, byAuthor.Count);
            Assert.AreEqual(1, byTitle.Count);
            Assert.AreEqual("Пушкин А.С.", byTitle[0].Author);
        }


        [TestMethod]
        public void ValidSortByPrice()
        {
            DataService ds = new DataService();

            List<Book> books = new List<Book>
            {
                new Book { Author = "Толстой Л.Н.", Title = "Война и мир", Year = 2015, Price = 1200 },
                new Book { Author = "Пушкин А.С.", Title = "Евгений Онегин", Year = 2017, Price = 400 },
                new Book { Author = "Булгаков М.А.", Title = "Мастер и Маргарита", Year = 2022, Price = 750 }
            };

            List<Book> sorted = ds.SortByPrice(books);

            Assert.AreEqual(400, sorted[0].Price);
            Assert.AreEqual(750, sorted[1].Price);
            Assert.AreEqual(1200, sorted[2].Price);
        }

        [TestMethod]
        public void ValidStatistics()
        {
            DataService ds = new DataService();

            List<Book> books = new List<Book>
            {
                new Book { Author = "Толстой Л.Н.", Title = "Война и мир", Year = 2015, Price = 1200, IsNew = false, Copies = 3 },
                new Book { Author = "Пушкин А.С.", Title = "Евгений Онегин", Year = 2017, Price = 400, IsNew = false, Copies = 4 },
                new Book { Author = "Булгаков М.А.", Title = "Мастер и Маргарита", Year = 2022, Price = 800, IsNew = true, Copies = 5 }
            };

            Assert.AreEqual(3, ds.GetCount(books));
            Assert.AreEqual(12, ds.GetTotalCopies(books));
            Assert.AreEqual(2400, ds.GetSumPrice(books));
            Assert.AreEqual(800, ds.GetAveragePrice(books));
            Assert.AreEqual(1200, ds.GetMaxPrice(books));
            Assert.AreEqual(400, ds.GetMinPrice(books));
        }

        [TestMethod]
        public void ValidFilters()
        {
            DataService ds = new DataService();

            List<Book> books = new List<Book>
            {
                new Book { Author = "Толстой Л.Н.", Title = "Война и мир", Year = 2015, Price = 1200, IsNew = false, Copies = 3 },
                new Book { Author = "Пушкин А.С.", Title = "Евгений Онегин", Year = 2017, Price = 400, IsNew = false, Copies = 4 },
                new Book { Author = "Булгаков М.А.", Title = "Мастер и Маргарита", Year = 2022, Price = 800, IsNew = true, Copies = 5 }
            };

            List<Book> onlyNew = ds.FilterNew(books);
            List<Book> byYear = ds.FilterByYear(books, 2016, 2022);

            Assert.AreEqual(1, onlyNew.Count);
            Assert.AreEqual("Мастер и Маргарита", onlyNew[0].Title);
            Assert.AreEqual(2, byYear.Count);
        }
    }
}
           