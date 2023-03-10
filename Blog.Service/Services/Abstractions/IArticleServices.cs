using Blog.Entity.DTOS.Article;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstractions
{
    public interface IArticleServices
    {
        Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();
    }
}
