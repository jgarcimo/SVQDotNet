using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6_Repository.Mappers
{
    public static class BookMapper
    {
        public static EF6Model.Book ToEF6Model(Entities.Book entity)
        {
            return new EF6Model.Book()
            {
                BookId = entity.BookId,
                ISBN = entity.ISBN,
                NumPages = entity.NumPages,
                PublicationDate = entity.PublicationDate,
                Title = entity.Title
            };
        }

        public static Entities.Book ToBaseModel(EF6Model.Book entity)
        {
            return new Entities.Book()
            {
                BookId = entity.BookId,
                ISBN = entity.ISBN,
                NumPages = entity.NumPages,
                PublicationDate = entity.PublicationDate,
                Title = entity.Title
            };
        }

    }
}
