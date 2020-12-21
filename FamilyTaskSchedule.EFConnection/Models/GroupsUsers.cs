using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyTaskSchedule.EFConnection.Models
{
    public class GroupsUsers
    {
        public int Id { get; set; }
        
        public Guid UserId { get; set; }
        public User User { get; set; }
        
        public Guid GroupId { get; set; }
        public Group Group { get; set; }
        
        
        public Guid RoleId { get; set; }
        public GroupRoles Role { get; set; }
    }
}
