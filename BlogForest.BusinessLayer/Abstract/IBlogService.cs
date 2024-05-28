﻿using BlogForest.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        public List<Blog> TGetBlogsWithCategoryAndUser();
        public List<Blog> TGetLast2BlogByAppUser(int id);
    }
}
