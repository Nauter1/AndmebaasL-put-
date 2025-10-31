using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Core.Domain
{
    public class Exhibit
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Curator {  get; set; }
        public string Description { get; set; }
        public IEnumerable<DisplayDates> DisplayId { get; set; } = new List<DisplayDates>();
    }
}
