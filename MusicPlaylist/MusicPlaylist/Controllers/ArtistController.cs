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
                
                return RedirectToAction(nameof(ArtistController.All), "Artist");
            }
            //TODO: страница за грешки
            return RedirectToAction(nameof(HomeController.Error), "Home");
        }

        public IActionResult All()
        {
            IEnumerable<ArtistViewModel> model = _artistService.GetArtists();
            return View(model);
        }

        public IActionResult Details(int id) 
        { 
            ArtistDetailsModel? model = _artistService.GetArtistDetails(id);
            if(model == null)
            {
                return RedirectToAction(nameof(ArtistController.All), "Artist");
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            ArtistEditModel? model = _artistService.EditArtist(id);
        }
    }
}