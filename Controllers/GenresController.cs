using Bookstore2.Models;
using Bookstore2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace Bookstore2.Controllers
{
	public class GenresController : Controller
	{
		public IActionResult Index()
		{
			List<Genre> genres = new List<Genre>
			{
				new Genre(1, "Drama"),
				new Genre(2, "Comédia"),
				new Genre(3, "Terror"),
				new Genre(4, "Ação"),
				new Genre(5, "Fantasia")
			};
			return View(genres);
		}



		// Método DELETE
		public async Task<IActionResult> Delete(int? id)
		{
			if (id is null)
			{
				return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
			}

			var obj = await _service.FindByIdAsync(id.Value);
			if (obj is null)
			{
				return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
			}

			return View(obj);
		}
		public IActionResult Error(string? message)
		{
			var viewModel = new ErrorViewModel
			{
				Message = message,
				RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
			};
			return View(viewModel);
		}
	}
}

