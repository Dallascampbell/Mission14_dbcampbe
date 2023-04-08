using api.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class MovieController : Controller
    {
        private MovieContext _context { get; set; }

        public MovieController(MovieContext temp)
        {
            _context = temp;
        }

        public IEnumerable<Movie> Get()
        {
            var x = _context.Movies.ToArray()
                .Where(m => m.Edited == "Yes")
                .OrderBy(m => m.Title);

            return x;
        }
    }
}
