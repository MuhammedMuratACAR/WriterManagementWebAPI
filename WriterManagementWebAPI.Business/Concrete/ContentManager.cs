using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WriterManagementWebAPI.Business.Interfaces;
using WriterManagementWebAPI.DataAccess.Interfaces;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.Business.Concrete
{
    public class ContentManager:GenericManager<Content>,IContentService
    {
        private readonly IGenericDal<Content> _genericDal;
        private readonly IContentDal _contentDal;
        public ContentManager(IGenericDal<Content> genericDal, IContentDal contentDal) :base(genericDal)
        {
            _genericDal = genericDal;
            _contentDal = contentDal;
        }

        public Task<List<Content>> GetAllPostedTimeAsync()
        {
            return _contentDal.GetAllAsync(I => I.ContentDate);
        }
    }
}
