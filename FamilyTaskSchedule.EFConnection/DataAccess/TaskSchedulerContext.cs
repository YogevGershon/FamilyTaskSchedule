using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyTaskSchedule.EFConnection.DataAccess
{
    public class TaskSchedulerContext : DbContext
    {
        public TaskSchedulerContext(DbContextOptions options) : base(options) { }
    }
}
