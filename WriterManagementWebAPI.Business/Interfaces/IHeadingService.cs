using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.Business.Interfaces
{
    public interface IHeadingService : IGenericService<Heading>
    {
        Task<List<Heading>> GetAllByWriterIdAsync(int writerId);
        Task<List<Heading>> GetAllTableAsync();
    }
}
