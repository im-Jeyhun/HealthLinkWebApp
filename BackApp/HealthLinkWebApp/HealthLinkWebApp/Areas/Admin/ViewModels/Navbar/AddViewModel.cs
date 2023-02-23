using System.ComponentModel.DataAnnotations;

namespace HealthLinkWebApp.Areas.Admin.ViewModels.Navbar
{
    public class AddViewModel
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Url { get; set; }

        public List<UrlViewModel>? Urls { get; set; }

        [Required]
        public int RowNumber { get; set; }

        [Required]
        public bool IsFooter { get; set; }

        [Required]
        public bool IsHeader { get; set; }

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
