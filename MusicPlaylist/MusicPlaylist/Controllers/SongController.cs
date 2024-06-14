using Microsoft.AspNetCore.Mvc;
using MusicPlaylist.Services.Interfaces;
using MusicPlaylist.ViewModels.Song;

namespace MusicPlaylist.Controllers
{
    public class SongController : Controller
    {
        private readonly ISongService _songService;

        public SongController(ISongService songService)
        {
            _songService = songService;
        }

        public IActionResult MySongs()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNewSong()
        {
            SongFormModel model = new SongFormModel();
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
    }
}
