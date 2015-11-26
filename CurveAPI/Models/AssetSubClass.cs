using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace etrmpro.CurveAPI.Models
{
    public class AssetSubClass : AbstractEntity
    {
        [Key]
        public int AssetSubClassId { get; set; }
        public int AssetClassId { get; set; }
        [ForeignKey("AssetClassId")]
        public AssetClass AssetClass { get; set; }
        [Required]
        public string Name { get; set; }
    }
}