using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace etrmpro.CurveAPI.Models
{
    public class Curve : AbstractMultitenantEntity, IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CurveId { get; set; }
        [Required]
        public string Name { get; set; }

        public int GetId()
        {
            return CurveId;
        }
    }
}
