using MagazynEdu.DataAcces;
using MagazynEdu.DataAcces.Entities;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MagazynEdu.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookCaseController : ControllerBase
    {
        private readonly IRepository<BookCase> _bookCaseRepository;
        public BookCaseController(IRepository<BookCase> bookCaseRepository)
        {
            _bookCaseRepository = bookCaseRepository;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<BookCase> GetAll() => _bookCaseRepository.GetAll();

        [HttpGet]
        [Route("{bookCaseId}")]
        public BookCase GetBookCaseId(int bookCaseId) => _bookCaseRepository.GetById(bookCaseId);

    }
}
