using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.Entities.Interfaces;

namespace WriterManagementWebAPI.Entities.Concrete
{

    public class Category : ITable
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; } 
        public List<Heading> Headings { get; set; }

    }
   
}
