using System.Collections.Generic;

namespace API.Models
{
    // use if app needs pagination
    public class Paged<T> where T : class
    {
        public IEnumerable<T> Items { get; set; }
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
    }
}
