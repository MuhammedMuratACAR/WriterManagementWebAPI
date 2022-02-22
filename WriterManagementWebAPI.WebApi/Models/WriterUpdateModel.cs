using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WriterManagementWebAPI.WebApi.Models
{
    public class WriterUpdateModel
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterImagePath { get; set; }
        public IFormFile Image { get; set; }
        public string WriterAbout { get; set; }
        public string WriterMail { get; set; }
        public bool WriterStatus { get; set; }

    }
}
