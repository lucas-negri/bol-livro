using bolte.Models;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;


namespace bolte.Controllers.Data
{
	public class BookstoreContext : DbContext
	{
		public BookstoreContext(IdentityDbContextOptions<BookstoreContext> options) : base(Option)
		{

		}


		public DbSet<Genres> Genres { get; set; }
	}

}