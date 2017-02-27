using System;

namespace AbovetheTreeline.data
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public BookDetails bookdetail { get; set; }
    }
}
