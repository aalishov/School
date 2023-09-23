using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace P01_TouristSites.Data.Models
{
    [PrimaryKey(nameof(TouristId), nameof(BonusPrizeId))]
    public class TouristBonusPrize
    {
        
        public int TouristId { get; set; }

        public virtual Tourist Tourist { get; set; }

        public int BonusPrizeId { get; set; }

        public virtual BonusPrize BonusPrize { get; set; }
    }
}
