﻿using Blog.Core.Entities;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    public class ArticleDTO : EntityBase 
    {
      
        public string Title { get; set; }

        public string Content { get; set; }

        public int ViewCount { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid ImageId { get; set; }
        public Image Image { get; set; }
    }
}
