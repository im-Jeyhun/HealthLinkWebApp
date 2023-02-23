
using AutoMapper;
using HealthLinkWebApp.Areas.Admin.ViewModels.SubNavbar;
using HealthLinkWebApp.Database;
using HealthLinkWebApp.Database.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace HealthLinkWebApp.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/subnavbar")]
    //[Authorize(Roles = "admin")]
    public class SubNavbarController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        private readonly IActionDescriptorCollectionProvider _provider;
        public SubNavbarController(DataContext dataContext, IActionDescriptorCollectionProvider provider, IMapper mapper)
        {
            _dataContext = dataContext;
            _provider = provider;
            _mapper = mapper;
        }

        #region List
        [HttpGet("list", Name = "admin-subnavbar-list")]
        public async Task<IActionResult> ListAsync()
        {
            var subNavbars = await _dataContext.SubNavbars
                .ToListAsync();

            var result = _mapper.Map<List<ListItemViewModel>>(subNavbars);

            return View(result);
        }
        #endregion

        #region Add
        [HttpGet("add-subnavbar", Name = "admin-subnavbar-add")]
        public async Task<IActionResult> AddAsync()
        {
            var navbars = await _dataContext.Navbars.ToListAsync();

            var urls = _provider.ActionDescriptors.Items.Where(u => u.RouteValues["Area"] != "admin").ToList();

            var result = _mapper.Map<AddViewModel>((urls,navbars));


            return View(result);
        }

        [HttpPost("add-subnavbar", Name = "admin-subnavbar-add")]
        public async Task<IActionResult> AddAsync(AddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var navbars = await _dataContext.Navbars.ToListAsync();

                var urls = _provider.ActionDescriptors.Items.Where(u => u.RouteValues["Area"] != "admin").ToList();

                var result = _mapper.Map<AddViewModel>((urls, navbars));

                return View(result);
            }

            var subNavbar = _mapper.Map<SubNavbar>(model);


            await _dataContext.SubNavbars.AddAsync(subNavbar);
            await _dataContext.SaveChangesAsync();

            return RedirectToRoute("admin-subnavbar-list");
        }

        #endregion

        #region Update
        [HttpGet("update-subnavbar/{id}", Name = "admin-subnavbar-update")]
        public async Task<IActionResult> UpdateAsync([FromRoute] int id)
        {
            var subnavbar = await _dataContext.SubNavbars.FirstOrDefaultAsync(b => b.Id == id);

            var navbars = await _dataContext.Navbars.ToListAsync();

            var urls = _provider.ActionDescriptors.Items.Where(u => u.RouteValues["Area"] != "admin").ToList();
            if (subnavbar is null)
            {
                return NotFound();
            }

            var result = _mapper.Map<UpdateViewModel>((subnavbar, urls, navbars ));

            return View(result);
        }

        [HttpPost("update-subnavbar/{id}", Name = "admin-subnavbar-update")]
        public async Task<IActionResult> UpdateAsync(int id, UpdateViewModel model)
        {
            var subnavbar = await _dataContext.SubNavbars.FirstOrDefaultAsync(b => b.Id == id);

            if (subnavbar is null) return NotFound();

            if (!ModelState.IsValid)
            {
                model.Navbars = await _dataContext.Navbars.Where(n => n.Id == subnavbar.NavbarId)
                    .Select(n => new UpdateViewModel.NavbarViewModel(n.Id, n.Name)).ToListAsync();
                model.Urls = _provider.ActionDescriptors.Items.Where(u => u.RouteValues["Area"] != "admin")
                .Select(u => new UpdateViewModel.UrlViewModel(u!.AttributeRouteInfo.Template)).ToList();

                return View(model);
            }


            _mapper.Map(model, subnavbar);

            await _dataContext.SaveChangesAsync();

            return RedirectToRoute("admin-subnavbar-list");
        }
        #endregion

        #region Delete
        [HttpPost("delete/{id}", Name = "admin-subnavbar-delete")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            var subNavbar = await _dataContext.SubNavbars.FirstOrDefaultAsync(b => b.Id == id);
            if (subNavbar is null) return NotFound();


            _dataContext.SubNavbars.Remove(subNavbar);

            await _dataContext.SaveChangesAsync();

            return RedirectToRoute("admin-subnavbar-list");
        }
        #endregion


    }

}
