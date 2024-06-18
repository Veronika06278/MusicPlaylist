using Microsoft.AspNetCore.Mvc;
using MusicPlaylist.Services.Interfaces;
using MusicPlaylist.ViewModels.Song;

namespace MusicPlaylist.Controllers
{
    public class SongController : Controller
    {
        private readonly ISongService _songService;
        private readonly IArtistService _artistService;

        public SongController(ISongService songService, IArtistService artistService)
        {
            _songService = songService;
            _artistService = artistService;
        }

        public IActionResult MySongs()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNewSong()
        {
            SongFormModel model = new SongFormModel();
            model.Artists=_artistService.GetArtistsDropDown();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewSong(SongFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            bool isAdded=await _songService.AddSongAsync(model);
            if (isAdded)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            return RedirectToAction(nameof(HomeController.Error), "Home");
        }

        public IActionResult All()
        {
            IEnumerable<SongViewModel> model = _songService.GetSong();
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            
        }
    }
}
