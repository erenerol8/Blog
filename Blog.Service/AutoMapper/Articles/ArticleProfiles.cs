using AutoMapper;
using Blog.Entity.DTOS.Articles;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.AutoMapper.Articles
{
    public class ArticleProfiles : Profile
    {
        public ArticleProfiles() 
        {
            CreateMap<ArticlesDto, ArticleDTO>().ReverseMap();        
        }
    }
}
