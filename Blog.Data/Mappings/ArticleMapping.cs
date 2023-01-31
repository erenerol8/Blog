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
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "ASP.NET Core Deneme Makalesi",
                Content = "Lorem ipsum dolares lorem ipsum dolar dolares ipsum lorem Türkiye Cumhuriyeti Fenerbahce Ankara ve Kar",
                ViewCount = 15,
                CategoryId = Guid.Parse("981F97C3B8D949BF8CAE9446F57A504F"),
                ImageId = Guid.Parse("52E698D32D58428B8B7C2CD54B384ECD"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Entity Framework Core Deneme Makalesi",
                Content = "Entity Framework Lorem ipsum dolares lorem ipsum dolar dolares ipsum lorem Türkiye Cumhuriyeti Fenerbahce Ankara ve Kar",
                ViewCount = 15,
                CategoryId=Guid.Parse("58952BF2A492477FA89B619DC9D22AF2"),
                ImageId = Guid.Parse("4F4E212407AF42F9A3619D47B944193E"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            }
          );
        }
    }
}
