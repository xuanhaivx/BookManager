using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookManager.Models
{
    public class Book
    {
        public int IdBook { get; set; }
        public string TitleBook { get; set; }
        public string AuthorBook { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}