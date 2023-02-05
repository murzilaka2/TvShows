using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TvShows.Models
{
    public enum Genre
    {
        Drama,
        Comedy,
        Romance,
        [Display(Name = "Romantic Comedy")]
        RomCom,
        Crime,
        Mystery
    }
}
