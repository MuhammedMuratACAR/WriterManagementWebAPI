using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.DataAccess.Interfaces
{
    public interface IWriterDal:IGenericDal<Writer>
    {
       Task <List<Writer>> GetAllWriterPagination(int totalPage, int aktivePage);
    }
}
