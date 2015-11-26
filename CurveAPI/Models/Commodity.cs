using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace etrmpro.CurveAPI.Models
{
    public class Commodity : AbstractEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommodityId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}