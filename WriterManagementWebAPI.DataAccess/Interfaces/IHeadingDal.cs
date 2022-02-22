using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.DataAccess.Interfaces
{
    public interface IHeadingDal : IGenericDal<Heading>
    {
        Task<List<Heading>> GetAllByWriterIdAsync(int writerId);
        Task<List<Heading>> GetAllTableAsync();
    }
}
