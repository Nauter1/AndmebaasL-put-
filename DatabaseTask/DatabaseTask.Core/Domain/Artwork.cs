using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Core.Domain
{
    public enum Status
    {  Storage, ForSale, Destroyed, Borrowed, OnExhibit }
    public enum Technique
    { Oil, Crayon, Watercolor, Statue, Carving }
    public class Artwork
    {
        [Key]
        public int Id { get; set; }
        public DateOnly DateOfCreation { get; set; }
        public Technique Technique { get; set; }
        public string Dimensions { get; set; }
        public Status Status { get; set; }
        public ICollection<Artist> ArtistID { get; set; }
    }
}
