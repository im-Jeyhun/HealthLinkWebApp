namespace HealthLinkWebApp.Areas.Admin.ViewModels.Navbar
{
    public class ListItemViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Url { get; set; }

        public int RowNumber { get; set; }
        public bool IsFooter { get; set; }
        public bool IsHeader { get; set; }

    }
}
