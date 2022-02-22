using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.DataAccess.Interfaces;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfContentRepository : EfGenericRepository<Content>, IContentDal
    {
    }
}
