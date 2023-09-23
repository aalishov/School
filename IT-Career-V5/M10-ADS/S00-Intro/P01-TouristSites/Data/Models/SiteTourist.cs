namespace P01_TouristSites.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;

    [PrimaryKey(nameof(TouristId), nameof(SiteId))]
    public class SiteTourist
    {

        public int TouristId { get; set; }
        public virtual Tourist Tourist { get; set; }

        public int SiteId { get; set; }
        public virtual Site Site { get; set; }

    }
}
