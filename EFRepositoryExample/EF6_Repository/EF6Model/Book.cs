namespace EF6_Repository.EF6Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public int BookId { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        public long ISBN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PublicationDate { get; set; }

        public int? NumPages { get; set; }
    }
}
