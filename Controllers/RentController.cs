using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Data;

namespace MovieRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {
        private readonly MovieDbContext _dbContext;

        public RentController(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
