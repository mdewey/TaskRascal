using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskRascal.Models
{
    public class Chore
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ChoreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeCompleted { get; set; }
        public DateTime TimeAssigned { get; set; }
        public ChoreStatus Status { get; set; }
        
        // FKs
        [ForeignKey("Family")]
        public Guid FamilyId { get; set; }
        public virtual Family Family { get; set; }

        [ForeignKey("AssingedBy")]
        public int AssignById{ get; set; }
        public virtual UserProfile AssingedBy{ get; set; }
        
        [ForeignKey("AssignedTo")]
        public int AssignedToId { get; set; }
        public virtual UserProfile AssignedTo { get; set; }
    }
}