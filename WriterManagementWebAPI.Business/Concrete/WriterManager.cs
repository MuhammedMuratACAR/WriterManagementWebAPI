using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WriterManagementWebAPI.Business.Interfaces;
using WriterManagementWebAPI.DataAccess.Interfaces;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.Business.Concrete
{
    public class WriterManager : GenericManager<Writer>, IWriterService
    {
        private readonly IGenericDal<Writer> _genericDal;
        private readonly IWriterDal _writerDal;

        public WriterManager(IGenericDal<Writer> genericDal, IWriterDal writerDal) :base(genericDal)
        {
            _genericDal = genericDal;
            _writerDal = writerDal;
        }

        public Task<List<Writer>> GetAllOrderDescAsync()
        {
            return _writerDal.GetAllAsync(I => I.WriterID);
        }

        public Task<List<Writer>> GetAllWriterPagination(int totalPage, int activePage = 1)
        {
            return _writerDal.GetAllWriterPagination(totalPage, activePage);
        }

        public Task<List<Writer>> SearchAsync(string searchString)
        {
            return _writerDal.GetAllAsync(I => I.WriterName.Contains(searchString) || I.WriterSurname.Contains(searchString) || I.WriterMail.Contains(searchString), I => I.WriterID);
        }
    }
}
