using AutoMapper;
using HealthLinkWebApp.Areas.Admin.ViewModels.Navbar;
using HealthLinkWebApp.Database;
using HealthLinkWebApp.Database.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace HealthLinkWebApp.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/navbar")]
    public class NavbarController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        private readonly IActionDescriptorCollectionProvider _provider;



        public NavbarController(DataContext dataContext, IMapper mapper, IActionDescriptorCollectionProvider provider)
        {
            _dataContext = dataContext;
            _mapper = mapper;
            _provider = provider;
        }

        [HttpGet("list",Name ="admin-navbar-list")]
        public async Task<IActionResult> ListAsync()
        {

            var navbars = await _dataContext.Navbars.ToListAsync();

            var modelResult = _mapper.Map<List<ListItemViewModel>>(navbars);

            return View(modelResult);
        }

        [HttpGet("add", Name = "admin-navbar-add")]
        public async Task<IActionResult> AddAsync()
        {
      
            var url = _provider.ActionDescriptors.Items.Where(u => u.RouteValues["Area"] != "admin").ToList();

            var result = _mapper.Map<AddViewModel>(url);
       
            return View(result);
        }

        [HttpPost("add", Name = "admin-navbar-add")]
        public async Task<IActionResult> AddAsync(AddViewModel model)
        {
            var navbar = _mapper.Map<Navbar>(model);                

            _dataContext.Navbars.Add(navbar);

           await _dataContext.SaveChangesAsync();

            return RedirectToRoute("admin-navbar-list");
        }

        [HttpGet("update/{id}", Name = "admin-navbar-update")]
        public async Task<IActionResult> UpdateAsync(int id)
        {
            var navbar = await _dataContext.Navbars.FirstOrDefaultAsync(n => n.Id == id);
            if(navbar == null) return NotFound();

            var url = _provider.ActionDescriptors.Items.Where(u => u.RouteValues["Area"] != "admin").ToList();


            var result = _mapper.Map<UpdateViewModel>((navbar,url));

            return View(result);

        }

        [HttpPost("update/{id}",Name ="admin-navbar-update")]
        public async Task<IActionResult> UpdateAsync(UpdateViewModel model, int id)
        {
            var navbar = await _dataContext.Navbars.FirstOrDefaultAsync(n => n.Id == id);
            if (navbar == null) return NotFound();



            //var result = _mapper.Map<Navbar>(model);

            _mapper.Map(model, navbar);

            await _dataContext.SaveChangesAsync();

            return RedirectToRoute("admin-navbar-list");

        }

        [HttpPost("delete/{id}", Name = "admin-navbar-delete")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var navbar = await _dataContext.Navbars.FirstOrDefaultAsync(n => n.Id == id);
            if (navbar == null) return NotFound();


            _dataContext.Navbars.Remove(navbar);

            await _dataContext.SaveChangesAsync();

            return RedirectToRoute("admin-navbar-list");

        }

    }
}
