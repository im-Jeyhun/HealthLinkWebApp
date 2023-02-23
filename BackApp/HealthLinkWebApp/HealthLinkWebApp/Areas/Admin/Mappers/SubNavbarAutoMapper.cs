using AutoMapper;
using HealthLinkWebApp.Areas.Admin.ViewModels.SubNavbar;
using HealthLinkWebApp.Database.Models;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace HealthLinkWebApp.Areas.Admin.Mappers
{
    public class SubNavbarAutoMapper : Profile
    {
   
        public SubNavbarAutoMapper()
        {
            //show
            CreateMap<SubNavbar, ListItemViewModel>()
                .ForMember(d => d.NavbarName , opt => opt.MapFrom(src => src.Navbar.Name));

            //add(get)
            CreateMap<(List<ActionDescriptor> urls, List<Navbar> navbar), AddViewModel>()
                .ForMember(d => d.Urls, opt => opt.MapFrom(src => src.urls))
                .ForMember(d => d.Navbars, opt => opt.MapFrom(src => src.navbar));

            CreateMap<ActionDescriptor, AddViewModel.UrlViewModel>()
              .ForMember(d => d.Path, opt => opt.MapFrom(src => src.AttributeRouteInfo.Template));

            CreateMap<Navbar, AddViewModel.NavbarViewModel>()
              .ForMember(d => d.Id, opt => opt.MapFrom(src => src.Id))
              .ForMember(d => d.Title, opt => opt.MapFrom(src => src.Name));

            //add(post)
            CreateMap<AddViewModel, SubNavbar>();



            //update(get)
            CreateMap<(SubNavbar SubNavbar, List<ActionDescriptor> urls, List<Navbar> navbars), UpdateViewModel>()
                .ForMember(d => d.Urls, opt => opt.MapFrom(src => src.urls))
                .ForMember(d => d.Navbars, opt => opt.MapFrom(src => src.navbars))
                .ForMember(d => d.Name, opt => opt.MapFrom(src => src.SubNavbar.Name))
                .ForMember(d => d.RowNumber, opt => opt.MapFrom(src => src.SubNavbar.RowNumber))
                .ForMember(d => d.Url, opt => opt.MapFrom(src => src.SubNavbar.Url))
                .ForMember(d => d.NavbarId, opt => opt.MapFrom(src => src.SubNavbar.NavbarId));

            CreateMap<ActionDescriptor, UpdateViewModel.UrlViewModel>()
             .ForMember(d => d.Path, opt => opt.MapFrom(src => src.AttributeRouteInfo.Template));

            CreateMap<Navbar, UpdateViewModel.NavbarViewModel>()
             .ForMember(d => d.Id, opt => opt.MapFrom(src => src.Id))
             .ForMember(d => d.Name, opt => opt.MapFrom(src => src.Name));

            //update(post)

            CreateMap<UpdateViewModel, SubNavbar>();


        }
    }
}
