using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.Business.Interfaces
{
    public interface IWriterService : IGenericService<Writer>
    {
        Task<List<Writer>> SearchAsync(string searchString);
        Task<List<Writer>> GetAllOrderDescAsync();
        Task<List<Writer>> GetAllWriterPagination(int totalPage, int activePage = 1);


    }
}
