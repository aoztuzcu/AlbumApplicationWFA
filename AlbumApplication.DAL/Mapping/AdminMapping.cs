using AlbumApplication.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumApplication.DAL.Mapping
{
    public class AdminMapping : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasQueryFilter(x=>x.IsDeleted==false);
            builder.Property(x=>x.UserName).HasMaxLength(15);
            builder.HasData(new Admin { Id = 1, UserName = "admin", Password = "admin" });
        }
    }
}
