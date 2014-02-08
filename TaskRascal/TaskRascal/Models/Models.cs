using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace TaskRascal.Models
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int PointsValues { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public Boolean NeedsApproval { get; set; }
        public int MininmumAge { get; set; }
    }

    public class Goals
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int PointsValues { get; set; }
        
    }
}