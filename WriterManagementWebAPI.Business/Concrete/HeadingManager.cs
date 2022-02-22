using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WriterManagementWebAPI.Business.Interfaces;
using WriterManagementWebAPI.DataAccess.Interfaces;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.Business.Concrete
{
    public class HeadingManager : GenericManager<Heading>, IHeadingService
    {
        private readonly IGenericDal<Heading> _genericDal;
        private readonly IHeadingDal _headingDal;
        public HeadingManager(IGenericDal<Heading> genericDal, IHeadingDal headingDal) : base(genericDal)
        {
            _genericDal = genericDal;
            _headingDal = headingDal;
        }

        public Task<List<Heading>> GetAllByWriterIdAsync(int writerId)
        {
            return _headingDal.GetAllByWriterIdAsync(writerId);
        }

        public Task<List<Heading>> GetAllTableAsync()
        {
            return _headingDal.GetAllTableAsync();
        }
    }
}
