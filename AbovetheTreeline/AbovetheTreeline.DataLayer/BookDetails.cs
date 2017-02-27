using System;
using System.Collections.Generic;
using System.Text;

namespace AbovetheTreeline.DataLayer
{
    public class BookDetails
    {
        public int Id { get; set; }
        public string isbn { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
    }
}
