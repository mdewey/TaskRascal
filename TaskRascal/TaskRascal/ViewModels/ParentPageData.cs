using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskRascal.Models;

namespace TaskRascal.ViewModels
{
    public class ParentPageData
    {
        public IEnumerable<Activity> Activities { get; set; }
        public IEnumerable<TaskItem> Tasks { get; set; }
        public UserProfile ThisUser { get; set; }
        public bool AnyPendingTasks { get; set; }
        public int OverallTaskProgress { get; set; }
        public int NumberOfTasks { get; set; }

        public ParentPageData()
        {
            if (this.Activities != null)
                AnyPendingTasks = Activities.Any(a => a.ActivityType == ActivityType.PendingApproval);
        }

        public ParentPageData(IEnumerable<Activity> activities, IEnumerable<TaskItem> tasks, UserProfile user, int progress, int numberofTasks)
        {
            this.Activities = activities;
            this.Tasks = tasks;
            this.ThisUser = user;
            AnyPendingTasks = Activities.Any(a => a.ActivityType == ActivityType.PendingApproval);
            this.OverallTaskProgress = progress;
            this.NumberOfTasks= numberofTasks;
        }



    }
}