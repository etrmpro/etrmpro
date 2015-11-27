using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace etrmpro.CurveAPI.Models
{
    public class Point : AbstractEntity, IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PointId { get; set; }
        public int MarketId { get; set; }
        [ForeignKey("MarketId")]
        public Market Market { get; set; }
        public string Name { get; set; }

        public int GetId()
        {
            return PointId;
        }
    }
}