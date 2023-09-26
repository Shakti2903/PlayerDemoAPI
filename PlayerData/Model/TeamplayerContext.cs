using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerData.Model
{
    public class TeamplayerContext:DbContext
    {
        public TeamplayerContext(DbContextOptions<TeamplayerContext>options) : base(options) {
            //  Database.EnsureCreated();
        }

        public DbSet<RoleInfo> RoleInfos { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
    }
}
