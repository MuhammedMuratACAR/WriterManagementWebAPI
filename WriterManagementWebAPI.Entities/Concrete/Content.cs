using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.Entities.Interfaces;

namespace WriterManagementWebAPI.Entities.Concrete
{
    public class Content:ITable
    {

        public int ContentID { get; set; }
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; } = DateTime.Now;
        public bool ContentStatus { get; set; } 

        public int HeadingID { get; set; }
        public Heading Heading { get; set; }

        public int? WriterID { get; set; }
        public Writer Writer { get; set; }

    }
}
