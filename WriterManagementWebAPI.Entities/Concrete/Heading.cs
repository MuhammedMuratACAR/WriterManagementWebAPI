using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.Entities.Interfaces;

namespace WriterManagementWebAPI.Entities.Concrete
{
    public class Heading:ITable
    {
        public int HeadingID { get; set; }
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; } = DateTime.Now;
        public bool HeadingStatus { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public int WriterID { get; set; }
        public Writer Writer { get; set; }

        public List<Content> Contents { get; set; }

    }
}
