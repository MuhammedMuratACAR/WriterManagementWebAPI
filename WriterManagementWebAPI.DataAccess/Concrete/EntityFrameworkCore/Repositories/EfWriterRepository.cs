using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriterManagementWebAPI.DataAccess.Concrete.EntityFrameworkCore.Context;
using WriterManagementWebAPI.DataAccess.Interfaces;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfWriterRepository : EfGenericRepository<Writer>, IWriterDal
    {
        public async Task<List<Writer>> GetAllWriterPagination(int totalPage, int activePage)
        {
            using var context = new WriterManagementWebAPIContext();
           var returnValue = context.Writers.OrderByDescending(I => I.WriterID);

            totalPage = (int)Math.Ceiling((double)returnValue.Count() / 3);
            return await returnValue.Skip((activePage - 1) * 3).Take(3).ToListAsync();
        }


        public async Task<List<Heading>> GetAllByWriterIdAsync(int writerId)
        {
            using var context = new WriterManagementWebAPIContext();
            return await context.Headings.Join(context.Writers, h => h.HeadingID, hw => hw.WriterID, (heading, writer) => new
            {
                heading,
                writer
            }).Where(I => I.writer.WriterID == writerId).Select(I => new Heading
            {
                HeadingName = I.heading.HeadingName,
                HeadingDate = I.heading.HeadingDate

            }).ToListAsync();
        }
    }
}
