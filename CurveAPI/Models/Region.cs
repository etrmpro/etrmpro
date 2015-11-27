using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace etrmpro.CurveAPI.Models
{
    public class Region : AbstractEntity, IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegionId { get; set; }
        public int CommodityId { get; set; }
        [ForeignKey("CommodityId")]
        public Commodity Commodity { get; set; }
        [Required]
        public string Name { get; set; }

        public IList<Market> Markets { get; set; }

        public int GetId()
        {
            return RegionId;
        }
    }
}