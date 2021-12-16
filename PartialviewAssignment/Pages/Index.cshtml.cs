using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PartialviewAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialviewAssignment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Film> film;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            film = new List<Film>();

            film.Add(new Film()
            {
                FilmTitle = "HOUSE OF GUCCI",
                Duration = "2h 3m",
                FilmDescription = " House of Gucci vacillates between inspired camp " +
                " and dour drama too often to pull off a confident runway strut," +
                "  but Lady Gaga's note-perfect performance has a timeless style all its own. " +
                "House of Gucci is inspired by the shocking true story," +
                "  of the family behind the Italian fashion empire."
            });

            film.Add(new Film()
            {
                FilmTitle = "GHOSTBUSTERS: AFTERLIFE",
                Duration = "1h 30m",
                FilmDescription = " Ghostbusters: Afterlife crosses the streams between, " +
                " franchise revival and exercise in nostalgia -- and this time around, " +
                "the bustin' mostly feels good." +
                " When a single mother and her two children move to a new town, " +
                " they soon discover they have a connection to the original Ghostbusters and " +
                " the secret legacy their grandfather left behind. "
            });

            film.Add(new Film()
            {
                FilmTitle = "RED NOTICE",
                Duration = "1h 57m",
                FilmDescription = " Red Notice's big budget and A-list cast add up to a slickly competent action comedy" + 
                " In the world of international crime, " +
                " an Interpol agent attempts to hunt down  " +
                " and capture the world's most wanted art thief. "
            });

            film.Add(new Film()
            {
                FilmTitle = "KING RICHARD ",
                Duration = "2h 26m",
                FilmDescription = " King Richard transcends sport biopic formulas with refreshingly nuanced storytelling " +
                " and a towering performance from Will Smith in the title role." +
                " Armed with a clear vision and a brazen 78-page plan," +
                " Richard Williams is determined to write his daughters, Venus and Serena, into history. " 
            });

        }

        public void OnGet()
        {

        }
    }
}
