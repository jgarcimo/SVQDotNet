using System;
using System.Collections.Generic;

namespace EFCore_Repository.EFCoreModel
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public long Isbn { get; set; }
        public DateTime? PublicationDate { get; set; }
        public int? NumPages { get; set; }
    }
}
