using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            return View(dogs);
        }
      /*  public IActionResult Hello()
        {
            DogViewModel doggo = new DogViewModel()
            {
                Name = "Rambo",
                Age = 3
            };
            return View(doggo);
        }*/

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }
        // data binding
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            // return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

       /* public string Hello()
        {
            return "Who's there?";
        }*/
    }
}
