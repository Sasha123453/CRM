using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CRM
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskUser> TaskUsers { get; set; }
        public DbSet<UserQuery> UserQuerys { get; set; }
        public DbSet<UserFriend> UserFriends { get; set; }
        public ApplicationContext() : base("DefaultConnection") {}
    }
}
