using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Repository.Mappers
{
    public static class BookMapper
    {
        public static EFCoreModel.Book ToEFCoreModel(Entities.Book entity)
        {
            return new EFCoreModel.Book()
            {
                BookId = entity.BookId,
                Isbn = entity.ISBN,
                NumPages = entity.NumPages,
                PublicationDate = entity.PublicationDate,
                Title = entity.Title
            };
        }

        public static Entities.Book ToBaseModel(EFCoreModel.Book entity)
        {
            return new Entities.Book()
            {
                BookId = entity.BookId,
                ISBN = entity.Isbn,
                NumPages = entity.NumPages,
                PublicationDate = entity.PublicationDate,
                Title = entity.Title
            };
        }
    }
}
