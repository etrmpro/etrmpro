using System.ComponentModel.DataAnnotations;

namespace etrmpro.CurveAPI.Models
{
    public class AssetClass : AbstractEntity
    {
        [Key]
        public int AssetClassId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}