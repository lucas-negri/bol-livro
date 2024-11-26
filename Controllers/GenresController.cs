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
<<<<<<< HEAD
		{

			return View(_service.FindAll());
		}

		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create()
=======
>>>>>>> 8fb9162d746dd0a6cf99d3cd00e7318745b4f1dc
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

<<<<<<< HEAD
		public async Task<IActionResult> Delete(int? id)
		{
			if (id is null)
			{
				return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
			}

=======


		// Método DELETE
		public async Task<IActionResult> Delete(int? id)
		{
			if (id is null)
			{
				return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
			}

>>>>>>> 8fb9162d746dd0a6cf99d3cd00e7318745b4f1dc
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
<<<<<<< HEAD
}
=======
}

>>>>>>> 8fb9162d746dd0a6cf99d3cd00e7318745b4f1dc
