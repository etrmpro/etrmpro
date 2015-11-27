using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace etrmpro.CurveAPI.Models
{
    public class Curve : AbstractMultitenantEntity, IEntity, IValidatableObject
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CurveId { get; set; }
        public int MarketId { get; set; }
        [ForeignKey("MarketId")]
        public Market Market { get; set; }
        public int? PointId { get; set; }
        [ForeignKey("PointId")]
        public Point Point { get; set; }

        [Required]
        public string Name { get; set; }

        public int GetId()
        {
            return CurveId;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            IList<ValidationResult> validationResults = new List<ValidationResult>();
            if (PointId > 0 && Point == null)
            {
                var dbContext = new CurveServiceDbContext();
                Point point = dbContext.Points.Find(PointId);
                if (point == null)
                {
                    validationResults.Add(new ValidationResult("The PointId (" + PointId + ") supplied is invalid."));
                }
                else if (point.MarketId != MarketId)
                {
                    validationResults.Add(new ValidationResult("The Point (" + point + ") is not associated with the Market (" + Market + ")"));
                }
            }
            return validationResults;
        }
    }
}
