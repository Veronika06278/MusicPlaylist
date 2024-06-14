using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicPlaylist.Data;
using MusicPlaylist.Data.Models;
using MusicPlaylist.Services;
using MusicPlaylist.Services.Interfaces;
using MusicPlaylist.ViewModels.Artist;

namespace MusicPlaylist.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IArtistService _artistService;

        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        
        public IActionResult MyArtists()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNewArtist() 
        {
            ArtistFormModel model= new ArtistFormModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewArtist(ArtistFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool isAdded = await _artistService.AddAsync(model);
            if (isAdded)
            {
                //TODO: да пренасочва към страница със всички артисти
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            //TODO: страница за грешки
            return RedirectToAction(nameof(HomeController.Error), "Home");
        }
    }
}