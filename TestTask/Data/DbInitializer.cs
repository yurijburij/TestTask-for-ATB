using TestTask.Models;
using System;
using System.Diagnostics;
using System.Linq;
using TestTask.Data;
using Hangfire.Server;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(WorkContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Workers.Any())
            {
                return;   // DB has been seeded
            }

            var workers = new TestTask.Models.Worker[]
            {
            new TestTask.Models.Worker{ID=1,Full_Name="Yurij Burij",Id_department=1,Birthday=DateTime.Parse("2005-09-01"),Sex="муж",City="Lviv",Adress="Lukasha,5",Phone_number="321312312"}
            
            };
            foreach (TestTask.Models.Worker s in workers)
            {
                context.Workers.Add(s);
            }
            context.SaveChanges();
            

            
        }
    }
}