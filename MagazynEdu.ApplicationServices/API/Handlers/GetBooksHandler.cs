using System;
using System.Collections.Generic;
using System.Linq;
using MagazynEdu.ApplicationServices.API.Domain;
using MagazynEdu.DataAcces.Entities;
using System.Threading;
using MagazynEdu.DataAcces;
using MediatR;

namespace MagazynEdu.ApplicationServices.API.Handlers
{
    public class GetBooksHandler: IRequestHandler<GetBooksRequest, GetBooksResponse>
    {
        private readonly IRepository<Book> _bookRepository;
        public GetBooksHandler(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public Task<GetBooksResponse> Handle(GetBooksRequest request, CancellationToken cancellationToken)
        {
            var books = _bookRepository.GetAll();
            var domineBuks= books.Select(x => new Domain.Models.Book()
            {
                Id = x.Id,
                Title = x.Title,
              
            });
            var response = new GetBooksResponse()
            {
                Data = domineBuks.ToList()
            };
            return Task.FromResult(response);
        }
    }
}
