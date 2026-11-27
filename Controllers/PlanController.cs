using Gym_Project.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gym_Project.Controllers
{
    public class PlanController : Controller
    {
        private GymDbContext context = new GymDbContext();

        public async Task<IActionResult> Index() 
        {
            var plans = await context.Plans.ToListAsync();
            return View(plans);
        }

    }
}
