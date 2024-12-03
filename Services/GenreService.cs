using bolte.Controllers.Data;


using bolte.Models;
using System.Data;
=======
using Microsoft.EntityFrameworkCore;

=======
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



        // POST: Genres/Edit/x
        public async Task UpdateAsync(Genre genre)
        {
            bool hasAny = await _context.Genres.AnyAsync(x => x.Id == genre.Id);

            if (!hasAny)
            {
                throw new NotFoundException("Id não encontrado");
            }
            // Tenta atualizar
            try
            {
                _context.Update(genre);

                await _context.SaveChangesAsync();
            }
            
            catch (DbUpdateConcurrencyException ex)
            {
                throw new DbConcorrencyException(ex.Message);
            }
        }
```
=======
=======
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

746dd0a6cf99d3cd00e7318745b4f1dc
=======
	}
}
