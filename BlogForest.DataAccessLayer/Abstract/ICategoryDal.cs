using BlogForest.DtoLayer.CategoryDtos;
using BlogForest.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.DataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        List<ResultCategoryWithCountDto> GetCategoryWithCount();
    }
}
