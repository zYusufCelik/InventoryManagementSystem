using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Core.Entities
{
    public abstract class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public virtual DateTime CreatedOn { get; set; } = DateTime.Now;
        public virtual DateTime? UpdatedOn { get; set; }
        public virtual DateTime? DeletedOn { get; set; }
        [StringLength(16)]
        public string CreatedBy { get; set; }
        [StringLength(16)]
        public string UpdatedBy { get; set; }
        [StringLength(16)]
        public string DeletedBy { get; set; }
    }
}
