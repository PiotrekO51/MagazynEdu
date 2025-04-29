using Microsoft.AspNetCore.Mvc;
using MagazynEdu.ApplicationServices.API.Domain;
using MagazynEdu.DataAcces;
using MediatR;
namespace MagazynEdu.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public BooksController(IMediator mediator)
        { 
            
            _mediator = mediator;
        }
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllBooks([FromQuery] GetBooksRequest request)
        {
            var response = await _mediator.Send(request);
            return this.Ok(response);
        }


    }
}
