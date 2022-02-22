using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.Entities.Interfaces;

namespace WriterManagementWebAPI.Entities.Concrete
{
    public class Writer:ITable
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterImagePath { get; set; }
        public string WriterAbout { get; set; }
        public string WriterMail { get; set; }
        public bool WriterStatus { get; set; }

        public List<Heading> Headings { get; set; }
        public List<Content> Contents { get; set; }

    
    }
}
