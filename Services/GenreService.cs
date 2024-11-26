using bolte.Controllers.Data;
using Microsoft.EntityFrameworkCore;

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

		public async Task RemoveAsync(int id) 
		{

			try
			{
				var obj = await _context.Genres.FindAsync(id);
				_context.Genres.Remove(obj);
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateException ex)
			{

				throw new integrityException(ex.Message);
			}
		
		
		}

	}
}
