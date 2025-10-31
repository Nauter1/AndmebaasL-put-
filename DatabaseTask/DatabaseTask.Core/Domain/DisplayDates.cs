using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Core.Domain
{
    public class DisplayDates
    {
        [Key]
        public int DisplayId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IEnumerable<Artwork> ArtworkId { get; set; } = new List<Artwork>();
        public IEnumerable<Exhibit> ExhibitId { get; set; } = new List<Exhibit>();
    }
}
