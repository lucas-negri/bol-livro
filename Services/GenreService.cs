using bolte.Controllers.Data;

namespace bolte.Services
{
	public class GenreService
	{
		private readonly BookstoreContext _context;

		public GenreService(BookstoreContext context)
		{

			_context = context;

		}
		public List<Genre> FindAll()
		{
		
		 return_context.Genres.Tolist();
		
		}

		public async void FindByIdAsync(int id)
		{
		
		
		}

	}
}
