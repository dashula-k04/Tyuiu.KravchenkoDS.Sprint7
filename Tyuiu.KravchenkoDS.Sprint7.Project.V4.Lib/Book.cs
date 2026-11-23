using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KravchenkoDS.Sprint7.Project.V4.Lib
{
    public class Book
    {

        public string Author { get; set; } = "";
        public string Title { get; set; } = "";
        public int Year { get; set; }
        public int Price { get; set; }
        public bool IsNew { get; set; }
        public int Copies { get; set; }

    }
}
