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
    public class EfHeadingRepository : EfGenericRepository<Heading>, IHeadingDal
    {
        public async Task<List<Heading>> GetAllByWriterIdAsync(int writerId)
        {
            using var context = new WriterManagementWebAPIContext();
            return await context.Headings.Join(context.Writers, h => h.HeadingID, hw => hw.WriterID, (heading, writer) => new
            {
                heading,
                writer
            }).Where(I => I.writer.WriterID == writerId).Select(I => new Heading
            {
               HeadingName=I.heading.HeadingName,
               HeadingDate=I.heading.HeadingDate
            
            }).ToListAsync();
        }

        public async Task<List<Heading>> GetAllTableAsync()
        {
            using var context = new WriterManagementWebAPIContext();
            return await context.Headings.Include(I => I.Writer).Include(I => I.Category).OrderByDescending(I => I.HeadingID).ToListAsync();
        }
    }
}
