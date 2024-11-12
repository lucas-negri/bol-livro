using bolte.Controllers.Data;
using bolte.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace bolte.Controllers
{

    public class GenresController : Controller
    {
        

        public IActionResult Index()
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
		{
			return View();

		}

        public async Task<IActionResult> Delete(int? id)
        {
        
        if (id is null)
            { 
             return RedirectToAction(nameof(erro) , new {message = "id nao fornecido"});

                var obj = ArrayWithOffset _service.findByidAsync(id.Value);
                if (obj is null)
                {
                    return redicttoaction(nameof(error), new { message = "id nao encontrado " });
                }
            return View(obj);
            }
        
        
        
        }
	}
}
