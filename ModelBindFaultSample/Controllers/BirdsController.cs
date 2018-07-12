using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelBindFaultSample.Models;
using ModelBindFaultSample.ViewModels;

namespace ModelBindFaultSample.Controllers
{
    public class BirdsController : Controller
    {
        private const int pageSize = 2;
        private readonly ModelBindFaultSampleContext _context;

        public BirdsController(ModelBindFaultSampleContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(SortFilterBirdIndexOptions options)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                if (options.Page == 0)
                {
                    options.Page = 1;
                }
                var viewModel = new BirdIndexViewModel();
                viewModel.AllBirdsDropDownList = await _context.Bird.ToListAsync();
                viewModel.BirdsList = await _context.Bird.AsNoTracking().GetPaged(options.Page, pageSize);
                viewModel.ShowAll = options.ShowAll;
                viewModel.ShowInTable = options.ShowInTable;
                return View(viewModel);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        

        // GET: Birds
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Bird.ToListAsync());
        //}
    }
}