namespace SportStore.Models.ViewModel
{
    public class PagingInfo
    {
        public int TotalItems { get; set; } // total number of items
        public int ItemsPerPage { get; set; } // number of items per page
        public int CurrentPage { get; set; } // current page number
        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); // total number of pages
    }
}
