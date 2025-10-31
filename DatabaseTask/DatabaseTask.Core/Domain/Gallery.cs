using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Core.Domain
{
    public class Gallery
    {
        [Key]
        public int Id { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public IEnumerable<Exhibit> ExhibitID { get; set; } = new List<Exhibit>();
    }
}
