using System.ComponentModel.DataAnnotations.Schema;

namespace etrmpro.CurveAPI.Models
{
    public interface IEntity
    {
        int GetId();
    }

    public abstract class AbstractEntity
    {
    }

    public abstract class AbstractMultitenantEntity
    {
        public int TenantId { get; set; }
        [ForeignKey("TenantId")]
        public Tenant Tenant { get; set; }
    }
}
