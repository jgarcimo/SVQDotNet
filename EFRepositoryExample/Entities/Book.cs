using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public long ISBN { get; set; }
        public DateTime? PublicationDate { get; set; }
        public int? NumPages { get; set; }
    }
}
