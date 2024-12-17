using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controlers
{
    public class HomeController : Controller
    {        
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public ActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel(_pieRepository.PiesOfTheWeek);

            return View(viewModel);
        }
    }
}
