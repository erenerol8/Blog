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
    public class ImageMapping : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("52E698D32D58428B8B7C2CD54B384ECD"),
                FileName = "image/testimage",
                FileType = "jpeg",
                CreatedBy = "Admin Test",
                IsDeleted = false,
            },
            new Image
            {
                Id = Guid.Parse("4F4E212407AF42F9A3619D47B944193E"),
                FileName = "image/testimage",
                FileType = "png",
                CreatedBy = "Admin Test",
                IsDeleted = false,
            }
            );
        }
    }
}
