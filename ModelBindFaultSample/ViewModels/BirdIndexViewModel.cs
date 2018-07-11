using ModelBindFaultSample.Models;
using System.Collections.Generic;

namespace ModelBindFaultSample.ViewModels
{
    public class BirdIndexViewModel
    {
        public bool ShowAll { get; set; }
        public bool ShowInTable { get; set; }
        public int SelectedBirdId { get; set; }
        //public List<Bird> BirdsList { get; set; }
        public PagedResult<Bird> BirdsList { get; set; }
        public IEnumerable<Bird> AllBirdsDropDownList { get; set; }
    }
}
