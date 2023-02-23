using System.ComponentModel.DataAnnotations;

namespace HealthLinkWebApp.Areas.Admin.ViewModels.SubNavbar
{
    public class AddViewModel
    {
        public AddViewModel()
        {

        }
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Url { get; set; }
        public List<UrlViewModel>? Urls { get; set; }

        [Required]
        public int RowNumber { get; set; }

        public int NavbarId { get; set; }
        public List<NavbarViewModel>? Navbars { get; set; }


        public class NavbarViewModel
        {
            public NavbarViewModel(int id, string title)
            {
                Id = id;
                Title = title;
            }
            public NavbarViewModel()
            {

            }
            public int Id { get; set; }
            public string Title { get; set; }
        }

        public class UrlViewModel
        {
            public UrlViewModel(string? path)
            {
                Path = path;
            }
            public UrlViewModel()
            {

            }

            public string? Path { get; set; }
        }
    }
}
