﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICarCategoryService:IGenericService<CarCategory>
    {
        void GetCategoriesWithCarCount();
    }
}
