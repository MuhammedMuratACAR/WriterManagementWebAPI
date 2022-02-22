using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.DTO.Interfaces;

namespace WriterManagementWebAPI.DTO.DTOs.WriterDtos
{
    public class WriterListDto : IDto
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterImagePath { get; set; }
        public string WriterAbout { get; set; }
        public string WriterMail { get; set; }
    }
}
