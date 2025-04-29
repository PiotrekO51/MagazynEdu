using MediatR;
using MagazynEdu.DataAcces;
namespace MagazynEdu.ApplicationServices.API.Domain;

public class GetBooksRequest: IRequest<GetBooksResponse>
{
}
