using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class UserRoleMapping : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("90DF825A-2D77-4586-9F8F-7BBC82EB3C16"),
                RoleId = Guid.Parse("CEE8C724-F055-4305-94F7-BC386EC6DB82"),
            },
            new AppUserRole
            {
                UserId = Guid.Parse("1ED47A79-F320-46F9-B79D-5B563A9EA703"),
                RoleId = Guid.Parse("F5BDAD15-96E8-4C15-B315-4EC584E1F7D4"),
            }
             );
        }
    }
}
