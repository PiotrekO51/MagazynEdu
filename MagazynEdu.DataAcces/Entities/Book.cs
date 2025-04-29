
using System.ComponentModel.DataAnnotations;
namespace MagazynEdu.DataAcces.Entities;

public class Book: EntityBase
{
    [Required]
    [MaxLength(250)]
    public string Title { get; set; } = string.Empty;

    public int Year { get; set; }
    public int BookCaseId { get; set; }

    public BookCase BookCase { get; set; }
    
    public List<Author> Authors { get; set; }

   
}
