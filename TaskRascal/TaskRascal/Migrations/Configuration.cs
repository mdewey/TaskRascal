using System.Collections.Generic;
using TaskRascal.Models;

namespace TaskRascal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<TaskRascal.Models.TRContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TaskRascal.Models.TRContext db)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //var Mom = new UserProfile() { UserName = "mom", Name = "Mommy", FamilyRole = FamilyRole.Parent };
            //var Child = new UserProfile() { UserName = "child", Name = "Johnny Camper", FamilyRole = FamilyRole.Child };


            //// add stuff
            //db.UserProfiles.AddOrUpdate(a => a.UserName, Child, Mom);
            //db.SaveChanges();

            //var goals = new List<Goals>
            //{
            //    new Goals()
            //    {
            //        Name = "Dr. Who Replica Sonic Screwdriver TV Remote.",
            //        Description = "",
            //        PointsValues = 80,
            //        UserId = Child.UserId,
            //        DateAdded =  new DateTime(2013,11,12)

            //    },
            //    new Goals()
            //    {
            //        Name = "Computer Time",
            //        Description = "15 minutes of computer time",
            //        PointsValues = 25,
            //        UserId = Child.UserId,
            //        DateAdded =  new DateTime(2013,12,13)

            //    },
            //    new Goals()
            //    {
            //        Name = "Chore free weekend.",
            //        Description = "Be immune from doing chores for a weekend.",
            //        PointsValues = 150,
            //        UserId = Child.UserId,
            //        DateAdded =  new DateTime(2014,1,12)

            //    }
            //};


            //var tasks = new List<TaskItem>() { };
            //tasks.Add(new TaskItem()
            //{
            //    Description = "",
            //    Name = "Finish your vegetables.",
            //    PointsValues = 1,
            //    DueDate = new DateTime(2014, 2, 16),
            //    CompletedDate = null,
            //    NeedsApproval = false,
            //    MininmumAge = 2,
            //    IsApproved = true,
            //    InMarketPlace = false,
            //    UserId = Child.UserId
            //});
            
            //tasks.Add(new TaskItem()
            //{
            //    Description = "Clean the car from all the mud and stuff after your weekend \"road trip\"",
            //    Name = "Wash the car.",
            //    PointsValues = 10,
            //    DueDate = new DateTime(2014, 2, 16),
            //    CompletedDate = null,
            //    NeedsApproval = false,
            //    MininmumAge = 16,
            //    IsApproved = true,
            //    InMarketPlace = false,
            //    UserId = Child.UserId
            //});
            
            //tasks.Add(new TaskItem()
            //{
            //    Description = "Take out the trash to curb, remeber to take out all three cans",
            //    Name = "Trim the hedges",
            //    PointsValues = 5,
            //    DueDate = new DateTime(2014, 2, 16),
            //    CompletedDate = null,
            //    NeedsApproval = false,
            //    MininmumAge = 9,
            //    IsApproved = true,
            //    InMarketPlace = false,
            //    UserId = Child.UserId
            //});
            
            //tasks.Add(new TaskItem()
            //{
            //    Description = "Take out the trash to curb, remeber to take out all three cans",
            //    Name = "Take out the trash",
            //    PointsValues = 5,
            //    DueDate = new DateTime(2014, 2, 16),
            //    CompletedDate = null,
            //    NeedsApproval = false,
            //    MininmumAge = 9,
            //    IsApproved = false,
            //    InMarketPlace = false,
            //    UserId = Child.UserId
            //});
            //tasks.Add(new TaskItem()
            //{
            //    Description = "Water the plants so that the hedges maintain a healthy look.",
            //    Name = "Water the plants",
            //    PointsValues = 5,
            //    DueDate = new DateTime(2014, 2, 19),
            //    CompletedDate = null,
            //    NeedsApproval = false,
            //    MininmumAge = 6,
            //    IsApproved = false,
            //    InMarketPlace = false,
            //    UserId = Child.UserId

            //});
            //tasks.Add(new TaskItem()
            //{
            //    Description = "Vacumming up the mess you kids made  in the rec room!",
            //    Name = "Vacuum the Play Room",
            //    DueDate = new DateTime(2014, 2, 9),
            //    CompletedDate = null,
            //    NeedsApproval = false,
            //    MininmumAge = 6,
            //    IsApproved = false,
            //    InMarketPlace = false,
            //    UserId = Child.UserId

            //});
            //tasks.Add(new TaskItem()
            //{
            //    Description = "Floss your teeth everyday other day for a month to develop good dental habits",
            //    Name = "Floss Your Teeth",
            //    PointsValues = 7,
            //    DueDate = new DateTime(2014, 2, 13),
            //    CompletedDate = null,
            //    NeedsApproval = false,
            //    MininmumAge = 4,
            //    IsApproved = false,
            //    InMarketPlace = false,
            //    UserId = Child.UserId

            //});
            //tasks.Add(new TaskItem()
            //{
            //    Description = "Mow the lawn in a diamond pattern to impress neighbor ned",
            //    Name = "Mow the Lawn",
            //    PointsValues = 5,
            //    DueDate = new DateTime(2014, 2, 16),
            //    CompletedDate = null,
            //    NeedsApproval = false,
            //    MininmumAge = 12,
            //    IsApproved = false,
            //    InMarketPlace = false,
            //    UserId = Child.UserId

            //});
            //tasks.Add(new TaskItem()
            //{
            //    Description = "Clean the windows in the kitchen",
            //    Name = "Window Cleaning",
            //    PointsValues = 3,
            //    DueDate = new DateTime(2014, 2, 14),
            //    CompletedDate = null,
            //    NeedsApproval = false,
            //    MininmumAge = 9,
            //    IsApproved = false,
            //    InMarketPlace = false,
            //    UserId = Child.UserId

            //});
            //tasks.Add(new TaskItem()
            //{
            //    Description = "Pick up the toys in your room that are on the floor.",
            //    Name = "Clean up Toys",
            //    PointsValues = 5,
            //    DueDate = new DateTime(2014, 2, 10),
            //    CompletedDate = null,
            //    NeedsApproval = false,
            //    MininmumAge = 9,
            //    IsApproved = false,
            //    InMarketPlace = false,
            //    UserId = Child.UserId

            //});



           
            //foreach (var item in goals)
            //{
            //    db.Goals.AddOrUpdate(a =>a.Name, item);
            //}
            //db.SaveChanges();
            //foreach (var item in tasks)
            //{
            //    db.Tasks.AddOrUpdate(a => a.Name, item);
            //}
            //db.SaveChanges();

            //#region Activites

            //var activites = new List<Activity>();
            //activites.Add(new Activity("Matt took out the trash", ActivityType.TaskCompleted, true, DateTime.Now));
            //activites.Add(new Activity("Mom told David \"Good Job on painting the fence\".", ActivityType.ParentNote, true, DateTime.Now));
            //activites.Add(new Activity("David met his goal of getting new toy.", ActivityType.GoalMet, true, new DateTime(2014,2,5)));
            //activites.Add(new Activity("Chris wants to barter for some more Rascals for weeding the garden", ActivityType.Barter, false, DateTime.Now));
            //activites.Add(new Activity("Verify that Peter just cleaned the dog.", ActivityType.PendingApproval, false, DateTime.Now));
            //activites.Add(new Activity("Chris wants to pass along a task.", ActivityType.PulledFromMarketPlace, false, DateTime.Now));
            //activites.Add(new Activity("Matt did not take out the trash", ActivityType.ApprovalRejected, true, new DateTime(2014, 2, 1)));
            //activites.Add(new Activity("Peter was able to earn enough points for a chore free weekend", ActivityType.GoalMet, true, new DateTime(2014, 1, 28)));
            //activites.Add(new Activity("Chris wants to barter for some more Rascals for cleaning the garage.", ActivityType.Barter, true, new DateTime(2014, 1, 22)));
            //activites.Add(new Activity("Chris trimmed the hedges.", ActivityType.TaskCompleted, true, new DateTime(2014, 1, 10)));
            //activites.Add(new Activity("Verify that David cleaned the kitchen.", ActivityType.PendingApproval, true, new DateTime(2013, 12, 12)));
            //activites.Add(new Activity("David is able to have an extra cookie after dinner for a week.", ActivityType.GoalApproved, true, new DateTime(2013, 12, 23)));

            //foreach (var item in activites)
            //{
            //    db.Activities.AddOrUpdate(a => a.DisplayText, item);
            //}
            //db.SaveChanges();


            //#endregion

        }
    }
}
