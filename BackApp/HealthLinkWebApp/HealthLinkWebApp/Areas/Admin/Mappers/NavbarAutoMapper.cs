using AutoMapper;
using HealthLinkWebApp.Areas.Admin.ViewModels.Navbar;
using HealthLinkWebApp.Database.Models;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace HealthLinkWebApp.Areas.Admin.Mappers
{
    public class NavbarAutoMapper : Profile
    {
   
        public NavbarAutoMapper()
        {
            CreateMap<Navbar, ListItemViewModel>();

            CreateMap<List<ActionDescriptor>, AddViewModel>()
                .ForMember(d => d.Urls, opt => opt.MapFrom(src => src));

            CreateMap<ActionDescriptor, AddViewModel.UrlViewModel>()
              .ForMember(d => d.Path, opt => opt.MapFrom(src => src.AttributeRouteInfo.Template));

            //CreateMap <List<T> Urls , AddViewModel>()
            //    .ForMember(d => d.Urls , opt => opt.MapFrom(opt => opt.Urls));

            CreateMap<AddViewModel, Navbar>();


            CreateMap<(Navbar navbar , List<ActionDescriptor> urls), UpdateViewModel>()
                .ForMember(d => d.Urls, opt => opt.MapFrom(src => src.urls))
                .ForMember(d => d.Name, opt => opt.MapFrom(src => src.navbar.Name))
                .ForMember(d => d.IsFooter, opt => opt.MapFrom(src => src.navbar.IsFooter))
                .ForMember(d => d.IsHeader, opt => opt.MapFrom(src => src.navbar.IsHeader))
                .ForMember(d => d.RowNumber, opt => opt.MapFrom(src => src.navbar.RowNumber))
                .ForMember(d => d.Url, opt => opt.MapFrom(src => src.navbar.Url))
                .ForMember(d => d.Id, opt => opt.MapFrom(src => src.navbar.Id));

            CreateMap<ActionDescriptor, UpdateViewModel.UrlViewModel>()
             .ForMember(d => d.Path, opt => opt.MapFrom(src => src.AttributeRouteInfo.Template));

            CreateMap<UpdateViewModel, Navbar>();


        }
    }
}
