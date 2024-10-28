﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Infrastructure.ViewModels;

namespace Library.Infrastructure.Mappers
{
    public static class BookMapper
    {
        public static BookViewModel Map(BookEntity entity)
        {
            var viewModel = new BookViewModel
            {
                id = entity.id,
                name = entity.name,
                publishinghouse = entity.publishinghouse,
                genre = entity.genre,
                writerfirstname = entity.writerfirstname,
                writesecondrname = entity.writesecondrname,
                writerlastname = entity.writerlastname,
            };
            return viewModel;
        }

        public static List<BookViewModel> Map(List<BookEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
        public static BookEntity Map(BookViewModel viewModel)
        {
            var entity = new BookEntity
            {
                id = viewModel.id,
                name = viewModel.name,
                publishinghouse = viewModel.publishinghouse,
                genre = viewModel.genre,
                writerfirstname = viewModel.writerfirstname,
                writesecondrname = viewModel.writesecondrname,
                writerlastname = viewModel.writerlastname,
            };
            return entity;
        }
    }
}
