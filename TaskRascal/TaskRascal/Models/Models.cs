using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace TaskRascal.Models
{

    public enum FamilyRole
    {
        Parent = 0,
        Child
    }

    public enum ActivityType
    {
        PendingApproval = 0,
        ApprovalRejected,
        Barter,
        AddToMarketPlace,
        PulledFromMarketPlace,
        GoalMet,
        TaskCompleted,
        GoalApproved,
        GoalSet
    }

    public class Activity
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public String DisplayText { get; set; }
        public ActivityType ActivityType { get; set; }
        public bool ShowForChild { get; set; }

        public Activity()
        {
            this.Id = Guid.NewGuid();
        }

        public Activity(string Text, ActivityType activityType, bool showForChild) :this()
        {
            this.DisplayText = Text;
            this.ActivityType = activityType;
            this.ShowForChild = showForChild;
        }
    }


    //NEXTSTEP: add family support when on board is implemented
    //public class Family
    //{
    //    public Guid Id { get; set; }
    //    public String Name { get; set; }
    //}

    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public FamilyRole FamilyRole { get; set; }
        public int TotalPoints { get; set; }

        public UserProfile()
        {
            this.UserId = Guid.NewGuid();
        }
    }



    public class TaskItem
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int PointsValues { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public Boolean NeedsApproval { get; set; }
        public int MininmumAge { get; set; }
        public bool IsApproved { get; set; }
        public bool InMarketPlace { get; set; }

        public Guid UserId { get; set; }
        
        [ForeignKey("UserId")]
        public virtual UserProfile Assignee { get; set; }

        public TaskItem()
        {
            this.Id = Guid.NewGuid();
        }
    }

    public class Goals
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int PointsValues { get; set; }
        public Guid UserId { get; set; }

        /// <summary>
        /// person the the goal is for
        /// </summary>
        [ForeignKey("UserId")]
        public virtual UserProfile User { get; set; }

        public Goals()
        {
            this.Id = Guid.NewGuid();
        }
    }
}