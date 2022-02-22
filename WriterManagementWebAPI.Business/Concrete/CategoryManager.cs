using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.Business.Interfaces;
using WriterManagementWebAPI.DataAccess.Interfaces;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.Business.Concrete
{
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        private readonly IGenericDal<Category> _genericDal;
        public CategoryManager(IGenericDal<Category> genericDal):base(genericDal)
        {
            _genericDal = genericDal;
        }
    }
}
