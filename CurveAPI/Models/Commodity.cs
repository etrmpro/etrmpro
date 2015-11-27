using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace etrmpro.CurveAPI.Models
{
    public class Commodity : AbstractEntity, IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommodityId { get; set; }
        public int AssetSubClassId { get; set; }
        [ForeignKey("AssetSubClassId")]
        public AssetSubClass AssetSubClass { get; set; }
        [Required]
        public string Name { get; set; }

        public int GetId()
        {
            return CommodityId;
        }
    }
}